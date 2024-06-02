using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace say_t_projesi
{
    public partial class Form1 : Form
    {

        private bool isDragging = false;
        private Point dragStartPoint = new Point(0, 0);
        private PictureBox currentDraggingIcon = null;
        private ContextMenuStrip iconContextMenu;
        private ToolStripMenuItem iconNameLabel;
        private ToolStripMenuItem inputCountBox;
        private ToolStripMenuItem deleteMenuItem;
        private ToolStripMenuItem changeColorMenuItemCikis;
        

        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;
        private List<Point> connectionPoints = new List<Point>();
        private List<Line> lines = new List<Line>();

        private const int connectionDistanceThreshold = 10;


        private ContextMenuStrip lineContextMenu;
        private Line selectedLine;
        private Point selectedPoint;
        private bool movingEndPoint = false;

        public ToolStripMenuItem LineColorBox { get; private set; }

        private ToolStripMenuItem deleteLineMenuItem;
        private ToolStripMenuItem lineLabel;
        private ToolStripMenuItem colorChangeLabel;

        private ContextMenuStrip iconContextMenuCikis;
        private ToolStripMenuItem iconNameLabelCikis;


        public Form1()
        {
            InitializeComponent();
            InitializeContextMenu();
            InitializeLineContextMenu();


            picBox.MouseDown += PicBox_MouseDown;
            picBox.MouseMove += PicBox_MouseMove;
            picBox.MouseUp += PicBox_MouseUp;
            picBox.Paint += picBox_Paint;

        }

        private void EXİTbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Boyutlandırbutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void Hidebutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Minimized;

        }

        private void BUFFER_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.BUFFER1, "BUFFER");

        }

        private void NOT_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.NOT, "NOT Gate");
        }

        private void AND_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.AND, "AND Gate");

        }

        private void OR_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.OR, "OR Gate");
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.XOR, "XOR Gate");
        }

        private void NAND_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.NAND, "NAND Gate");
        }

        private void NOR_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.NOR, "NOR Gate");
        }

        private void XNOR_Click(object sender, EventArgs e)
        {
            AddIconToPictureBox(Properties.Resources.XNOR, "XNOR Gate");
        }

        private void AddIconToPictureBox(Image icon, string iconName)
        {
            PictureBox iconPictureBox = new PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 50,
                Height = 50,
                BackColor = Color.Transparent
            };

            iconPictureBox.MouseDown += IconPictureBox_MouseDown;
            iconPictureBox.MouseMove += IconPictureBox_MouseMove;
            iconPictureBox.MouseUp += IconPictureBox_MouseUp;

            // İkonu başlangıçta formun merkezine ekleyin
            iconPictureBox.Location = new Point(
                (picBox.Width - iconPictureBox.Width) / 2,
                (picBox.Height - iconPictureBox.Height) / 2);

            iconPictureBox.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    ShowContextMenu(iconPictureBox, iconName, e.Location);
                    AddConnectionPointsRight(iconPictureBox, 1);
                }
            };

            picBox.Controls.Add(iconPictureBox);
        }

        private void IconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                currentDraggingIcon = sender as PictureBox;
                dragStartPoint = e.Location;
            }
        }

        private void IconPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && currentDraggingIcon != null)
            {
                currentDraggingIcon.Left += e.X - dragStartPoint.X;
                currentDraggingIcon.Top += e.Y - dragStartPoint.Y;
            }
        }

        private void IconPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                currentDraggingIcon = null;
            }
        }

        private void InitializeContextMenu()
        {
            iconContextMenu = new ContextMenuStrip();
            iconNameLabel = new ToolStripMenuItem();
            inputCountBox = new ToolStripMenuItem("Giriş Sayısı");
            deleteMenuItem = new ToolStripMenuItem("Delete");

            iconContextMenu.Items.AddRange(new ToolStripItem[]
            {
                iconNameLabel,
                inputCountBox,
                deleteMenuItem
            });

            var input1 = new ToolStripMenuItem("1");
            var input2 = new ToolStripMenuItem("2");

            input1.Click += (s, e) => AddConnectionPoints(iconContextMenu.Tag as PictureBox, 1);
            input2.Click += (s, e) => AddConnectionPoints(iconContextMenu.Tag as PictureBox, 2);

            inputCountBox.DropDownItems.AddRange(new ToolStripItem[] { input1, input2 });

            deleteMenuItem.Click += DeleteMenuItem_Click;
        }
        

        private void ShowContextMenu(PictureBox icon, string iconName, Point location)
        {
            iconNameLabel.Text = iconName;
            iconContextMenu.Tag = icon;
            iconContextMenu.Show(icon, location);
        }


        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (iconContextMenu.Tag is PictureBox icon)
            {
                picBox.Controls.Remove(icon);
            }
        }


       

        private void Giris_K_Click(object sender, EventArgs e)
        {
            AddIconToPictureBoxGİRİS(Properties.Resources.GİRİŞKUTUSU, "Giriş Kutusu");
            
        }

        private void AddIconToPictureBoxGİRİS(Image icon, string iconName)
        {
            PictureBox iconPictureBox = new PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 50,
                Height = 50,
                BackColor = Color.Transparent
            };

            iconPictureBox.MouseDown += IconPictureBox_MDown;
            iconPictureBox.MouseMove += IconPictureBox_MMove;
            iconPictureBox.MouseUp += IconPictureBox_MUp;

            // İkonu başlangıçta formun merkezine ekleyin
            iconPictureBox.Location = new Point(
                (picBox.Width - iconPictureBox.Width) / 2,
                (picBox.Height - iconPictureBox.Height) / 2);

            var contextMenu = InitializeContextMenuGirisK(iconPictureBox, iconName);


            iconPictureBox.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(iconPictureBox, e.Location);
                    AddConnectionPointsRight(iconPictureBox, 1);
                }
            };

            picBox.Controls.Add(iconPictureBox);
        }

        private void IconPictureBox_MDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                currentDraggingIcon = sender as PictureBox;
                dragStartPoint = e.Location;
            }
        }

        private void IconPictureBox_MMove(object sender, MouseEventArgs e)
        {
            if (isDragging && currentDraggingIcon != null)
            {
                currentDraggingIcon.Left += e.X - dragStartPoint.X;
                currentDraggingIcon.Top += e.Y - dragStartPoint.Y;
            }
        }

        private void IconPictureBox_MUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                currentDraggingIcon = null;
            }
        }


        private ContextMenuStrip InitializeContextMenuGirisK(PictureBox icon, string iconName)
        {
            // Bağlam menüsünü başlat
            var iconContextMenuGirisK = new ContextMenuStrip();
            var iconNameLabelGirisK = new ToolStripMenuItem(iconName);
            var deleteMenuItem = new ToolStripMenuItem("Delete");
            var changeColorMenuItemGirisK = new ToolStripMenuItem("Change Color");
            var entervalueMenuItemGirisK = new ToolStripMenuItem("Select Input");


            // Bağlam menüsüne öğeleri ekle
            iconContextMenuGirisK.Items.AddRange(new ToolStripItem[]
            {
                iconNameLabelGirisK,
                changeColorMenuItemGirisK,
                entervalueMenuItemGirisK,
                deleteMenuItem
            });

            var inp1 = new ToolStripMenuItem("1");
            var inp0 = new ToolStripMenuItem("0");  

            inp1.Click += (s, e) => icon.Image = Properties.Resources.GİRİŞ_KUTUSU_1;
            inp0.Click += (s, e) => icon.Image = Properties.Resources.GİRİŞKUTUSU;

            entervalueMenuItemGirisK.DropDownItems.AddRange(new ToolStripItem[] { inp1, inp0 });

            var gred = new ToolStripMenuItem("Kırmızı");
            var ggreen = new ToolStripMenuItem("Yeşil");
            var gblue = new ToolStripMenuItem("Mavi");
            var gorj = new ToolStripMenuItem("Renksiz");

            gred.Click += (s, e) => icon.BackColor = Color.FromArgb(120, 255, 0, 0); // %50 şeffaf kırmızı
            ggreen.Click += (s, e) => icon.BackColor = Color.FromArgb(120, 0, 255, 0); // %50 şeffaf yeşil
            gblue.Click += (s, e) => icon.BackColor = Color.FromArgb(100, 0, 50, 255); // %50 şeffaf mavi
            gorj.Click += (s, e) => icon.BackColor = Color.Transparent;

            changeColorMenuItemGirisK.DropDownItems.AddRange(new ToolStripItem[] { gred, ggreen, gblue, gorj });

            deleteMenuItem.Click += (s, e) => DeleteMenuItem_ClickGirisK(icon, e);

            return iconContextMenuGirisK;
        }

        private void DeleteMenuItem_ClickGirisK(PictureBox icn, EventArgs e)
        {
            if (icn is PictureBox icon)
            {
                picBox.Controls.Remove(icn);
            }
            
        }


        private void LED_Click(object sender, EventArgs e)
        {
            AddIconToPictureBoxCikis(Properties.Resources.YANAN_LED, "LED");
            InitializeContextMenuCikis();

        }

        private class Connection
        {
            public Point Location { get; set; }
            public int Value { get; set; }
            public Action UpdateConnection { get; set; }
        }



        private void Cikis_K_Click(object sender, EventArgs e)
        {
            AddIconToPictureBoxCikis(Properties.Resources.ÇIKIŞ_KUTUSU, "Çıkış Kutusu");
            InitializeContextMenuCikis();

        }

        private void AddIconToPictureBoxCikis(Image icon, string iconName)
        {
            PictureBox iconPictureBox = new PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 50,
                Height = 50,
                BackColor = Color.Transparent,
                Name = iconName
            };

            iconPictureBox.MouseDown += IconPictureBox_MDown;
            iconPictureBox.MouseMove += IconPictureBox_MMove;
            iconPictureBox.MouseUp += IconPictureBox_MUp;

            // İkonu başlangıçta formun merkezine ekleyin
            iconPictureBox.Location = new Point(
                (picBox.Width - iconPictureBox.Width) / 2,
                (picBox.Height - iconPictureBox.Height) / 2);



            iconPictureBox.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    ShowContextMenuCikis(iconPictureBox, iconName, e.Location);
                    AddConnectionPoints(iconPictureBox as PictureBox, 1);
                }
            };

            picBox.Controls.Add(iconPictureBox);
        }

        private void InitializeContextMenuCikis()
        {
            // Bağlam menüsünü başlat
            iconContextMenuCikis = new ContextMenuStrip();
            iconNameLabelCikis = new ToolStripMenuItem();
            deleteMenuItem = new ToolStripMenuItem("Delete");
            changeColorMenuItemCikis = new ToolStripMenuItem("Change Color");


            // Bağlam menüsüne öğeleri ekle
            iconContextMenuCikis.Items.AddRange(new ToolStripItem[]
            {
                iconNameLabelCikis,
                changeColorMenuItemCikis,
                deleteMenuItem
            });

            var cred = new ToolStripMenuItem("Kırmızı");
            var cgreen = new ToolStripMenuItem("Yeşil");
            var cblue = new ToolStripMenuItem("Mavi");
            var corj = new ToolStripMenuItem("Renksiz");

            

            cred.Click += (s, e) => {
                if (iconContextMenuCikis.Tag is PictureBox icon)
                {
                    icon.BackColor = Color.FromArgb(120, 255, 0, 0); // %50 şeffaf kırmızı
                }
            };
            cgreen.Click += (s, e) => {
                if (iconContextMenuCikis.Tag is PictureBox icon)
                {
                    icon.BackColor = Color.FromArgb(120, 0, 255, 0); // %50 şeffaf yeşil
                }
            };
            cblue.Click += (s, e) => {
                if (iconContextMenuCikis.Tag is PictureBox icon)
                {
                    icon.BackColor = Color.FromArgb(100, 0, 50, 255); // %50 şeffaf mavi
                }
            };
            corj.Click += (s, e) => {
                if (iconContextMenuCikis.Tag is PictureBox icon)
                {
                    icon.BackColor = Color.Transparent;
                }
            };

            changeColorMenuItemCikis.DropDownItems.AddRange(new ToolStripItem[] { cred, cgreen, cblue, corj });


            deleteMenuItem.Click += DeleteMenuItem_ClickCikis;
        }

        private void ShowContextMenuCikis(PictureBox icon, string iconName, Point location)
        {
            // Bağlam menüsünü göstermeden önce öğelerin değerlerini güncelle
            iconNameLabelCikis.Text = iconName;
            iconContextMenuCikis.Tag = icon;


            // Bağlam menüsünü göster
            iconContextMenuCikis.Show(icon, location);
        }

        private void DeleteMenuItem_ClickCikis(object sender, EventArgs e)
        {

            if (iconContextMenuCikis.Tag is PictureBox icn)
            {
                picBox.Controls.Remove(icn);
            }
        }

        private void AddConnectionPoints(PictureBox iconPictureBox, int numberOfPoints)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                Panel connectionPoint = new Panel
                {
                    Size = new Size(5, 5),
                    BackColor = Color.Black,
                    Location = new Point(0, 15 + 15 * i) // Bağlantı noktalarını 20 piksel arayla hizalayın
                };


                iconPictureBox.Controls.Add(connectionPoint);

                // Bağlantı noktalarının form üzerindeki mutlak konumlarını hesaplayın
                Point absoluteLocation = iconPictureBox.PointToScreen(connectionPoint.Location);
                absoluteLocation = picBox.PointToClient(absoluteLocation);
                connectionPoints.Add(absoluteLocation);
            }
        }

        private void AddConnectionPointsRight(PictureBox iconPictureBox, int numberOfPoints)
        {
            for (int i = 0; i < numberOfPoints; i++)
            {
                Panel connectionPoint = new Panel
                {
                    Size = new Size(5, 5),
                    BackColor = Color.Black,
                    Location = new Point(46, iconPictureBox.Height / 2 - 2) // Ortalanmış bağlantı noktası
                };

                iconPictureBox.Controls.Add(connectionPoint);

                // Bağlantı noktalarının form üzerindeki mutlak konumlarını hesaplayın
                Point absoluteLocation = iconPictureBox.PointToScreen(connectionPoint.Location);
                absoluteLocation = picBox.PointToClient(absoluteLocation);
                connectionPoints.Add(absoluteLocation);
            }
        }


        private void Cizgi_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            picBox.Cursor = Cursors.Cross;
        }

        private class Line
        {
            public Point Start { get; set; }
            public Point End { get; set; }
            public Pen Pen { get; set; }

            public Line(Point start, Point end)
            {
                Start = start;
                End = end;
                Pen = new Pen(Color.Black, 3); // Varsayılan bir kalem rengi ve genişliği atıyoruz
            }

        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                startPoint = e.Location;
                endPoint = e.Location;
                picBox.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (var line in lines)
                {
                    if (IsPointOnLine(e.Location, line.Start, line.End))
                    {
                        ShowLineContextMenu(line, e.Location);
                        return;
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                foreach (var line in lines)
                {
                    if (IsPointNear(e.Location, line.Start, 10))
                    {
                        selectedLine = line;
                        selectedPoint = line.Start;
                        movingEndPoint = false;
                        break;
                    }
                    else if (IsPointNear(e.Location, line.End, 10))
                    {
                        selectedLine = line;
                        selectedPoint = line.End;
                        movingEndPoint = true;
                        break;
                    }
                }


            }
            else
            {
                Panel connectionPoint = FindConnectionPoint(e.Location);
                if (connectionPoint != null)
                {
                    isDrawing = true;
                    startPoint = connectionPoint.Location;
                    endPoint = connectionPoint.Location;
                    picBox.Invalidate();
                }
            }

        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                picBox.Invalidate();
            }

            else if (selectedLine != null && e.Button == MouseButtons.Left)
            {
                if (movingEndPoint)
                {
                    selectedLine.End = e.Location;
                }
                else
                {
                    selectedLine.Start = e.Location;
                }

                // Bağlantı noktalarına yakınsa bağlantıyı sağla
                foreach (var point in connectionPoints)
                {
                    if (Math.Abs(selectedPoint.X - point.X) < connectionDistanceThreshold &&
                        Math.Abs(selectedPoint.Y - point.Y) < connectionDistanceThreshold)
                    {
                        if (movingEndPoint)
                        {
                            selectedLine.End = point;
                        }
                        else
                        {
                            selectedLine.Start = point;
                        }
                        break;
                    }
                }

                picBox.Invalidate();
            }


        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                isDrawing = false;
                picBox.Cursor = Cursors.Default;


                // Çizgiyi bağlantı noktalarına yapıştırma
                foreach (var point in connectionPoints)
                {
                    if (Math.Abs(endPoint.X - point.X) < connectionDistanceThreshold &&
                Math.Abs(endPoint.Y - point.Y) < connectionDistanceThreshold)
                    {
                        endPoint = point;
                        break;
                    }

                }

                lines.Add(new Line(startPoint, endPoint));

                picBox.Invalidate();
            }

            else if (selectedLine != null)
            {
                foreach (var point in connectionPoints)
                {
                    if (Math.Abs(selectedLine.Start.X - point.X) < 10 && Math.Abs(selectedLine.Start.Y - point.Y) < 10)
                    {
                        if (movingEndPoint)
                        {
                            selectedLine.End = point;
                        }
                        else
                        {
                            selectedLine.Start = point;
                        }
                        break;
                    }
                }

                selectedLine = null;
                picBox.Invalidate();
            }


        }

        private bool IsPointNear(Point p1, Point p2, int threshold)
        {
            return Math.Abs(p1.X - p2.X) < threshold && Math.Abs(p1.Y - p2.Y) < threshold;
        }


        private void picBox_Paint(object sender, PaintEventArgs e)
        {

            foreach (var line in lines)
            {
                e.Graphics.DrawLine(line.Pen, line.Start, line.End);
            }

            if (isDrawing)
            {
                using (Pen pen = new Pen(Color.Black, 3)) // Çizgi kalınlığını burada ayarlayabilirsiniz
                {
                    e.Graphics.DrawLine(pen, startPoint, endPoint);
                }
            }


        }

        private bool IsPointOnLine(Point p, Point start, Point end)
        {
            const int tolerance = 3;
            float distance = (Math.Abs((end.Y - start.Y) * p.X - (end.X - start.X) * p.Y + end.X * start.Y - end.Y * start.X) /
                              (float)Math.Sqrt(Math.Pow(end.Y - start.Y, 2) + Math.Pow(end.X - start.X, 2)));
            return distance <= tolerance;
        }

        private void InitializeLineContextMenu()
        {
            lineContextMenu = new ContextMenuStrip();
            lineLabel = new ToolStripMenuItem("Bağlantı Kablosu");
            colorChangeLabel = new ToolStripMenuItem("Renk Seçimi");
            deleteLineMenuItem = new ToolStripMenuItem("Delete");

            var redColor = new ToolStripMenuItem("Kırmızı");
            var greenColor = new ToolStripMenuItem("Yeşil");
            var blueColor = new ToolStripMenuItem("Mavi");

            redColor.Click += (s, e) => ChangeLineColor(Color.Red);
            greenColor.Click += (s, e) => ChangeLineColor(Color.Green);
            blueColor.Click += (s, e) => ChangeLineColor(Color.Blue);

            colorChangeLabel.DropDownItems.AddRange(new ToolStripItem[] { redColor, greenColor, blueColor });

            lineContextMenu.Items.AddRange(new ToolStripItem[] { lineLabel, colorChangeLabel, deleteLineMenuItem });

            deleteLineMenuItem.Click += DeleteLineMenuItem_Click;

        }
        

        private void DeleteLineMenuItem_Click(object sender, EventArgs e)
        {
            if (lineContextMenu.Tag is Line line)
            {
                lines.Remove(line);
                picBox.Invalidate();
            }
        }

        private void ShowLineContextMenu(Line line, Point location)
        {
            lineContextMenu.Tag = line;
            lineContextMenu.Show(picBox, location);
        }

        private void ChangeLineColor(Color color)
        {

            if (lineContextMenu.Tag is Line line && line.Pen != null)
            {
                line.Pen = new Pen(color, line.Pen.Width);
                picBox.Invalidate();
            }

        }

        private Panel FindConnectionPoint(Point location)
        {

            foreach (var point in connectionPoints)
            {
                if (Math.Abs(location.X - point.X) < connectionDistanceThreshold &&
                    Math.Abs(location.Y - point.Y) < connectionDistanceThreshold)
                {
                    // Panel türüne dönüştürme işlemi
                    foreach (Control control in picBox.Controls)
                    {
                        if (control is Panel panel && panel.Location == point)
                        {
                            return panel;
                        }
                    }
                }
            }
            return null;


        }

    }
} 
