using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopeeTool
{
    public partial class MainUI : DevExpress.XtraEditors.XtraForm
    {
        BindingList<RegisterInfo> Source = new BindingList<RegisterInfo>();
        public MainUI()
        {
            InitializeComponent();
        }
        private void MainUI_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            gridAccount.DataSource = Source;
            Application.ApplicationExit += (s, @event) => { GlobalVar.IsApplicationExist = true; };

            lueCountries.Properties.DataSource = new List<dynamic>
            {
                new {
                    CountryCode = "VN",
                    CountryName = "Vietnam"
                },
                new {
                    CountryCode = "US",
                    CountryName = "United States"
                },
                new {
                    CountryCode = "SG",
                    CountryName = "Singapore"
                },
                new {
                    CountryCode = "UK",
                    CountryName = "United Kingdom"
                },
                new {
                    CountryCode = "GE",
                    CountryName = "Germany"
                }
            };
            lueGSM.Properties.DataSource = new List<dynamic>
            {
                new {
                    GSMCode = "THUECODE",
                    GSMName = "thuecode.vn"
                },
                new {
                    GSMCode = "SIMTHUE",
                    GSMName = "simthue.com"
                },
                new {
                    GSMCode = "RENTCODE",
                    GSMName = "rentcode.co"
                }
            };
            new Thread(new ThreadStart(() =>
            {
                while (!GlobalVar.IsApplicationExist)
                {
                    try
                    {
                        gridAccount.RefreshDataSource();
                        Thread.Sleep(1000);
                    }
                    catch { }
                }
            })).Start();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomNumber f = new RandomNumber();
            f.FormSubmit += (number) =>
            {
                for (int i = 0; i < number; i++)
                {
                    string username = Utils.RandomUsername().ToLower();
                    string email = username + "@gmail.com";
                    Source.Add(new RegisterInfo()
                    {
                        Email = email,
                        Username = username,
                        Password = Utils.RandomPassword(),
                    });
                }
            };
            f.ShowDialog();
            btnStart.Enabled = Source.Any(s => s.State == RegisterResult.Idle);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            new Thread(new ThreadStart(new MethodInvoker(() =>
            {
                try
                {
                next:
                    var items = Source.Where(ix => !ix.Finish).Take(Convert.ToInt32(nudParallel.Value)).ToList();
                    if (items.Count() <= 0)
                        return;

                    foreach (var item in items)
                    {
                        new Thread(new ThreadStart(new MethodInvoker(() =>
                        {
                            item.State = RegisterResult.OnRegistering;
                            try
                            {
                                ShopeeRegister register = new ShopeeRegister();
                                item.State = register.Register(item, chkIpVN.Checked ? lueCountries.EditValue.ToString() : "");
                            }
                            catch { }
                            finally
                            {
                                item.Finish = true;
                            }
                            Thread.CurrentThread.Abort();
                        }))).Start();
                    }
                    while (!GlobalVar.IsApplicationExist && items.Any(i => !i.Finish))
                    {
                        Thread.Sleep(1000);
                    }
                    if (GlobalVar.IsApplicationExist)
                    {
                        return;
                    }
                    goto next;
                }
                finally
                {
                    btnStart.Enabled = true;
                    MessageBox.Show(this, "Completed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.CurrentThread.Abort();
                }
            }))).Start();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void viewAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    Clipboard.SetText(viewAccount.GetFocusedDisplayText());
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
            saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveDlg.FileName;
                viewAccount.ExportToXlsx(path);
            }
        }
    }
}
