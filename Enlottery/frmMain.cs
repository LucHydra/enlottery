using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Enlottery.Properties;
using Timer = System.Timers.Timer;

namespace Enlottery
{
    public partial class frmMain : Form
    {
        private Timer luckyTimmer;
        private Timer showNameTimmer;
        private int _prizeCount = 0;
        private int _stepCount = 1;
        private int _showLable = 0;

        private readonly List<ImageCollection> _imageUnitsCollectionst;
        private readonly List<ImageCollection> _imageTensCollectionst;
        private readonly List<ImageCollection> _imageHunderedCollectionst;

        private readonly List<ImageCollection> _imageUnitsCollections;
        private readonly List<ImageCollection> _imageTensCollections;
        private readonly List<ImageCollection> _imageHunderedCollections;

        private readonly List<LuckyMan> _luckyManQueue = new List<LuckyMan>();
        private readonly List<LuckyMan> _luckyMen = new List<LuckyMan>();
        private readonly List<string> _numberColumn = new List<string>
        {
            "1","2","3","4","5","6","7","8","9","10"
        };

        private LuckyMan _luckyMan;

        public frmMain()
        {
            InitializeComponent();
            //PlayBackgroundMusic();
            PrepareLuckyData();

            _imageUnitsCollectionst = GetImageLists();
            _imageTensCollectionst = GetImageLists();
            _imageHunderedCollectionst = GetImageLists();

            _imageUnitsCollections = GetImageLists();
            _imageTensCollections = GetImageLists();
            _imageHunderedCollections = GetImageLists();

            RandomPrize();
        }

        private void PlayBackgroundMusic()
        {
            var backgroundPlayback = new FileInfo("nhacxoso.wav");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = backgroundPlayback.FullName;
            player.Play();
        }

        private void PrepareLuckyData()
        {
            var a = new FileInfo("BuyTicket.xlsx");
            DataGridView grid = new DataGridView();
            var exelDs = ImportExcelXLS(a.FullName, true);
            int rIdx = 0;
            foreach (DataRow item in exelDs.Tables[0].Rows)
            {
                if (string.IsNullOrEmpty(item.ItemArray[0].ToString()))
                    continue;

                foreach (DataColumn col in exelDs.Tables[0].Columns)
                {
                    if (col.ColumnName == "Full Name")
                        continue;

                    if (col.ColumnName == "Total Price")
                        break;

                    if (_numberColumn.Contains(col.ColumnName))
                    {
                        var luckyNumber = item.ItemArray[Convert.ToInt32(col.ColumnName)].ToString();
                        if (string.IsNullOrEmpty(luckyNumber))
                            continue;
                        if (luckyNumber.Length == 2) luckyNumber = "0" + luckyNumber;

                        var isDuplicated = false;
                        foreach (var luckyMan in _luckyManQueue)
                        {
                            if (luckyMan.LuckyNumber == luckyNumber)
                            {
                                luckyMan.IsDuplicated = true;
                                isDuplicated = true;
                            }
                        }

                        _luckyManQueue.Add(new LuckyMan
                        {
                            Man = item.ItemArray[0].ToString(),
                            LuckyNumber = luckyNumber,
                            IsDuplicated = isDuplicated
                        });
                    }
                }
            }
        }

        private void RandomPrize()
        {
            _luckyManQueue.Shuffle();
            for (int i = 0; i < 9; i++)
            {
                Random rd = new Random();
                var index = rd.Next(_luckyManQueue.Count);
                var luckyMan = _luckyManQueue[index];

                _luckyMen.Add(new LuckyMan
                {
                    LuckyNumber = luckyMan.LuckyNumber,
                    Man = luckyMan.Man
                });
                Thread.Sleep(500);
            }
        }

        private DataSet ImportExcelXLS(string FileName, bool hasHeaders)
        {
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn;
            if (FileName.Substring(FileName.LastIndexOf('.')).ToLower() == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";

            DataSet output = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                conn.Open();

                DataTable schemaTable = conn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                foreach (DataRow schemaRow in schemaTable.Rows)
                {
                    string sheet = schemaRow["TABLE_NAME"].ToString();

                    if (!sheet.EndsWith("_"))
                    {
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                            cmd.CommandType = CommandType.Text;

                            DataTable outputTable = new DataTable(sheet);
                            output.Tables.Add(outputTable);
                            new OleDbDataAdapter(cmd).Fill(outputTable);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message + string.Format("Sheet:{0}.File:F{1}", sheet, FileName), ex);
                        }
                    }
                }
            }
            return output;
        }

        private List<ImageCollection> GetImageLists()
        {
            var imageCollections = new List<ImageCollection>();
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num0,
                            ImageNumber = "0"
                        });
                        break;
                    case 1:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num1,
                            ImageNumber = "1"
                        });
                        break;
                    case 2:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num2,
                            ImageNumber = "2"
                        });
                        break;
                    case 3:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num3,
                            ImageNumber = "3"
                        });
                        break;
                    case 4:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num4,
                            ImageNumber = "4"
                        });
                        break;
                    case 5:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num5,
                            ImageNumber = "5"
                        });
                        break;
                    case 6:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num6,
                            ImageNumber = "6"
                        });
                        break;
                    case 7:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num7,
                            ImageNumber = "7"
                        });
                        break;
                    case 8:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num8,
                            ImageNumber = "8"
                        });
                        break;
                    case 9:
                        imageCollections.Add(new ImageCollection
                        {
                            Image = Resources.num9,
                            ImageNumber = "9"
                        });
                        break;
                }
            }

            return imageCollections;
        }

        private void InvokeLuckyNumber(Label luckyLabel, string text, bool isEnabled = true)
        {
            Invoke(new Action(() =>
            {
                luckyLabel.Text = text;
                luckyLabel.Visible = isEnabled;
            }));
        }

        private void InvokeShowLabel()
        {
            Invoke(new Action(() =>
            {
                s1n.Visible = true;
                s2n.Visible = true;
                s3n.Visible = true;
                s4n.Visible = true;
                s5n.Visible = true;
                f1n.Visible = true;
                f2n.Visible = true;
                f3n.Visible = true;
                spn.Visible = true;
            }));
        }

        private void InvokeButton(Button generateButton, bool value)
        {
            Invoke(new Action(() =>
            {
                generateButton.Enabled = value;
            }));
        }

        private void InvokeLabel(LuckyMan luckyMan, bool isShown)
        {
            switch (_prizeCount)
            {
                case 1:
                    InvokeLuckyNumber(s1, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(s1n, luckyMan.Man, isShown);
                    break;
                case 2:
                    InvokeLuckyNumber(s2, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(s2n, luckyMan.Man, isShown);
                    break;
                case 3:
                    InvokeLuckyNumber(s3, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(s3n, luckyMan.Man, isShown);
                    break;
                case 4:
                    InvokeLuckyNumber(s4, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(s4n, luckyMan.Man, isShown);
                    break;
                case 5:
                    InvokeLuckyNumber(s5, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(s5n, luckyMan.Man, isShown);
                    break;
                case 6:
                    InvokeLuckyNumber(f1, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(f1n, luckyMan.Man, isShown);
                    break;
                case 7:
                    InvokeLuckyNumber(f2, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(f2n, luckyMan.Man, isShown);
                    break;
                case 8:
                    InvokeLuckyNumber(f3, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(f3n, luckyMan.Man, isShown);
                    break;
                case 9:
                    InvokeLuckyNumber(sp1, luckyMan.LuckyNumber);
                    InvokeLuckyNumber(spn, luckyMan.Man, isShown);
                    break;
            }
        }

        private void RandomLuckyMan(object sender, ElapsedEventArgs e)
        {
            var luckyRandom = new Random();
            
            var index = luckyRandom.Next(_luckyManQueue.Count);
            var runingLuckyMan = _luckyManQueue[index];

            // Running Unit
            if (_stepCount < 90)
            {                
                var runingUnitsNumber = runingLuckyMan.LuckyNumber.Substring(2);
                picUnits.Image = _imageUnitsCollectionst[Convert.ToInt32(runingUnitsNumber)].Image;
            }

            // Stop Unit
            if (_stepCount == 90)
            {
                var unitsNumber = _luckyMan.LuckyNumber.Substring(2);
                picUnits.Image = _imageUnitsCollections[Convert.ToInt32(unitsNumber)].Image;
            }

            // Running Tens
            if (_stepCount < 110)
            {
                var runingTensNumber = runingLuckyMan.LuckyNumber.Substring(1, 1);
                picTens.Image = _imageTensCollectionst[Convert.ToInt32(runingTensNumber)].Image;
            }
                
            // Stop Tens
            if (_stepCount == 110)
            {
                var tensNumber = _luckyMan.LuckyNumber.Substring(1, 1);
                picTens.Image = _imageTensCollections[Convert.ToInt32(tensNumber)].Image;
            }

            // Running Hundered
            if (_stepCount < 130)
            {
                var runingHunderedNumber = runingLuckyMan.LuckyNumber.Substring(0, 1);
                picHundreds.Image = _imageHunderedCollectionst[Convert.ToInt32(runingHunderedNumber)].Image;

                // InvokeLabel(runingLuckyMan, false);
            }

            // Stop Hundered
            if (_stepCount == 130)
            {
                var hunderedNumber = _luckyMan.LuckyNumber.Substring(0, 1);
                picHundreds.Image = _imageHunderedCollections[Convert.ToInt32(hunderedNumber)].Image;

                InvokeLabel(_luckyMan, true);
                InvokeButton(btnGenerate, true);

                _stepCount = 1;

                if (_prizeCount == 9)
                {
                    InvokeShowLabel();
                }

                luckyTimmer.Close();
            }

            _stepCount++;
        }

        private void LotteryRandom()
        {
            luckyTimmer.Enabled = true;
            luckyTimmer.Interval = (130);
            luckyTimmer.Elapsed += RandomLuckyMan;
        }
        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            luckyTimmer = new Timer();
            if (_prizeCount - 1 >= _luckyMen.Count)
            {
                _prizeCount = 0;
            }
            _prizeCount++;
            _luckyMan = _luckyMen[_prizeCount - 1];
            LotteryRandom();
        }
	}
}
