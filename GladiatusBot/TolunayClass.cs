using System;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Net;
using mshtml;

public class TolunayClass
{
    #region Kullanım Kılavuzu

    //------------------------------------------|
    //             KULLANMAK İÇİN:              |
    //------------------------------------------|
    //Solution>Add>Existing Item>TolunayClass.cs|
    //------------------------------------------|
    //TolunayClass degisken=new TolunayClass(); |
    //------------------------------------------|
    //          degisken.metod(koşul);          |
    //------------------------------------------|

    #endregion

    public void logWriter(string txt, TextBox log)
    {
        //Log yazdırma."log" isimli textBox gerektirir.
        //Ex:logWriter("Hello World")
        if (log.Text.Length > 5000)
            log.Text = String.Empty;
        log.Text += DateTime.Now.ToString("dd MMM") + " - " + DateTime.Now.ToString("HH:mm:ss") + "  --  " + txt + Environment.NewLine;
        log.SelectionStart = log.TextLength;
        log.ScrollToCaret();
    }

    public int sayfayuklendimi(string ara, HtmlDocument document, int sure)
    {
        //Değeri sayfa içinde arar içinde varsa sıra numarasını yoksa 0 döndürür. 
        //Ex:sayfayuklendimi("metin1|metin2",webBrowser1.Document,10)
        int sonuc = 0;
        DateTime t1 = DateTime.Now.AddSeconds(sure);

        string[] dizi;
        String HTML;


        dizi = ara.Split("|"[0]);

        while ((sonuc == 0) && (t1 > DateTime.Now))
        {

            wait(100);
            Application.DoEvents();

            if (document == null)
            {
                continue;
            }
            try
            {
                HTML = document.Body.OuterHtml;
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (HTML.Contains(dizi[i]))
                    {
                        sonuc = i + 1;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
            }

        }

        return sonuc;
    }

    public DataSet CommandExecuteReader(String sql, SqlConnection conn)
    {
        //SQL komutlarını execute eder. Tablo tutabilir. DataSet döndürür.
        //Ex:CommandExecuteReader("SQL komutu","SQL bağlantısı")
        //Ex:DataSet degisken=CommandExecuteReader("SQL komutu","SQL bağlantısı")
        //Ex App Config:<add key="sqlConn" value="user id=cevdet;data source=212.68.45.108,1433;persist security info=True;initial catalog=evrak_efor_digerg;password=atakan1325*--;connection timeout=6000000;"></add>
        //Ex VS Tanımlama:public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["sqlConn"].ToString())
        DataSet ds = new DataSet();
        try
        {
            SqlCommand myCommand = new SqlCommand(sql, conn);
            myCommand.CommandTimeout = 600;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand);

            dataAdapter.Fill(ds);
        }
        catch (Exception exp)
        {

        }
        finally
        {
        }

        return ds;
    }

    public string DownloadFile(string URL, string Location)
    {
        //Dosya indirir.
        //Ex:DownloadFile("http://www.site.com/resim.jpg","C:\\")        
        WebClient client = new WebClient();
        client.DownloadFile(URL, Location);
        return Location;
    }

    public String GetFileNameFromURL(string hrefLink)
    {
        //Linkten dosyanın ismini alır.
        //Ex:degisken=GetFileNameFromURL("http://www.site.com/resim.jpg)
        return Path.GetFileName(Uri.UnescapeDataString(hrefLink).Replace("/", "\\"));
    }

    public void CreateFolder(string FolderName)
    {
        //Klasör oluşturur. Path verilebilir.
        //Ex:Directory.CreateDirectory("DosyaAdı")
        Directory.CreateDirectory(Application.StartupPath+"\\"+FolderName);
    }

    private static void writeTxt(string folder, string text1, string text2, string text3, string text4, string text5)
    {
        //Txt dosyası oluşturur ve gönderilen verileri yazar. Metoda text değerleri eklenip çıkartılabilir.
        //Ex:writeTxt("C:\\", "Yazı1", "Yazı2", "Yazı3", "Yazı4", "Yazı5")
        string folderpath = folder;
        FileStream fs = new FileStream(folderpath, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(text1);
        sw.WriteLine(text2);
        sw.WriteLine(text3);
        sw.WriteLine(text4);
        sw.WriteLine(text5);
        sw.Flush();
        sw.Close();
        fs.Close();
    }

    public string WebRequestIste(string adres)
    {
        //Gidilen adresten dönen verileri string değişkene atar.
        //Ex:degisken=WebRequestIste("http://www.site.com")
        string sonuc = "";
        try
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(adres);
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";

            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                sonuc = sr.ReadToEnd();
            }

        }
        catch (Exception ex)
        {

        }

        return sonuc;
    }

    public void ImportFile(string dosya)
    {
        //Gönderilen CSV'yi parçalara bölerek değişkenlere atar. Alanlar arttırılıp, azaltılabilir.
        //Ex:ImportFile("C:\\Metin.csv")
        //Ex:ImportFile(File.FileName)
        string s = "";
        int j = 0;
        string[] lines = System.IO.File.ReadAllLines(dosya, Encoding.GetEncoding(1254));

        for (int i = 0; i <= lines.Length; i++)
        {
            Application.DoEvents();

            j = j + 1;

            string alan1 = "";
            string alan2 = "";
            string alan3 = "";

            s = lines[i].Trim();
            try
            {
                alan1 = s.Substring(0, s.IndexOf(";")).Trim();

                s = s.Substring(s.IndexOf(";") + 1, s.Length - s.IndexOf(";") - 1);
                alan2 = s.Substring(0, s.IndexOf(";")).Trim();

                s = s.Substring(s.IndexOf(";") + 1, s.Length - s.IndexOf(";") - 1);
                alan3 = s;


            }
            catch (Exception ex)
            {
            }

        }
    }

    public void dosyaSec(string filter)
    {
        //Seçilen dosyayı file isimli değişkene yükler. Filtrelerle dosya türü değiştirilebilir.
        //Ex:dosyaSec("csv")
        OpenFileDialog file = new OpenFileDialog();
        file.Filter = filter+" Dosyası |*."+filter;
        file.Title = filter+" Dosyası Seçiniz..";

        if (file.ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show("Dosya Yüklendi !");
        }
    }

    public void idDegerGir(string id, string deger, WebBrowser brow)
    {
        //Gönderilen değeri, id'ye girer.
        //Ex:idDegerGir("username","Tolunay")
        string check;
        do
        {
            brow.Document.GetElementById(id).SetAttribute("value", deger);
            check = brow.Document.GetElementById(id).GetAttribute("value").ToString();
        }
        while (check != deger);

    }

    public void butonaTikla(string text, WebBrowser brow)
    {
        //Gönderilen değeri içeren butona tıklar.
        //Ex:butonaTikla("Sorgula")
        foreach (HtmlElement item in brow.Document.GetElementsByTagName("button"))
        {
            if (item.OuterHtml.Contains(text))
            {
                item.InvokeMember("click");
            }
        }
    }

    public string degeriAl(string tagname, string aranilan, WebBrowser brow)
    {
        //Gönderilen veriyi belirtilen tag içinde arar. Bulursa tag içerisindeki string değeri gönderir. Bulamazsa boş string gönderir.
        //Ex:degisken=degeriAl("a","Tolunay")
        string sonuc = "";

        foreach (HtmlElement element in brow.Document.GetElementsByTagName(tagname))
        {
            if (element.InnerText.Contains(aranilan))
            {
                sonuc = element.InnerText;
            }

        }
        return sonuc;
    }

    public void breakJS(WebBrowser brow)
    {
        //Sayfada çalışmayan JavaScript kodlarının hatalarını getirmez.
        //Ex:breakJS()
        brow.ScriptErrorsSuppressed = true;
    }

    public void wait(int time)
    {
        //Belirtilen süre boyunca kodu bekletir.
        //Ex:wait(1000)
        DateTime t = DateTime.Now.AddMilliseconds(time);
        while (DateTime.Now < t)
        Application.DoEvents();
    }

    private object mycookie;

    public String creq(String URL, String post, String referer, string method)
    {
        String sonuc = "";

        Uri uri = new Uri(URL);
        if (mycookie == null)
        {
            mycookie = new CookieContainer();
        }

        var request = (HttpWebRequest)WebRequest.Create(URL);

        var postData = post;

        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        if (URL.Contains("PaymentAssociationSelect.aspx"))
        { request.AllowAutoRedirect = false; }


        if (referer != "")
        {
            request.Referer = referer;
        }

        request.KeepAlive = true;

        if (method == "JSONPOST")
        {
            request.Method = "POST";

            request.Accept = "application/json, text/javascript, */*; q=0.01";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.ContentType = "application/json;";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.6,en;q=0.4");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";

        }
        else if (method == "DPOST")
        {
            request.Method = "POST";

            request.Accept = "application/xml, text/xml, */*";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";

        }
        else
        {
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "text/html, application/xhtml+xml, image/jxr, */*";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "tr");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:51.0) Gecko/20100101 Firefox/51.0";
        }



        request.CookieContainer = (CookieContainer)mycookie;


        if (method == "POST" || method == "JSONPOST" || method == "DPOST")
        {
            byte[] data = new UTF8Encoding().GetBytes(postData);
            request.ContentLength = data.Length;
            //Encoding.ASCII.GetBytes(postData);
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
                stream.Close();
            }
        }

        using (HttpWebResponse lxResponse = (HttpWebResponse)request.GetResponse())
        {
            var cookieContainer = new CookieContainer();

            // önce önceki cookie yi alıyoruz


            cookieContainer = (CookieContainer)mycookie;

            foreach (Cookie cookie in lxResponse.Cookies)
            {

                cookieContainer.Add(uri, cookie);
                mycookie = cookieContainer;

            }

            if (lxResponse.GetResponseStream() != null)
            {
                StreamReader streamReader = new StreamReader(lxResponse.GetResponseStream(), Encoding.GetEncoding("utf-8"));

                //sonuc = new StreamReader(lxResponse.GetResponseStream()).ReadToEnd();

                sonuc = streamReader.ReadToEnd();
                lxResponse.Close();
                streamReader.Close();

            }
        }
        return sonuc;
    }

    public Boolean frameGeldimi(HtmlDocument doc, String Arama)
    {
        Boolean sonuc = false;
        try
        {
            if (doc.Body.OuterHtml.Contains(Arama))
                return true;
            else
                for (int i = 0; i < doc.Window.Frames.Count; i++)
                {
                    sonuc = frameGeldimi(doc.Window.Frames[i].Document, Arama);
                    if (sonuc)
                        return sonuc;
                }
            wait(100);
            return sonuc;
        }
        catch (Exception)
        {
            wait(500);
            return frameGeldimi(doc, Arama);
        }

    }
    public void jsExecute(string js, HtmlDocument doc)
    {
        js = js.Replace(@"\\", "");
        HtmlElement scriptElement = doc.CreateElement("script");
        IHTMLScriptElement element = (IHTMLScriptElement)scriptElement.DomElement;
        element.text = js;
        doc.GetElementsByTagName("head")[0].AppendChild(scriptElement);
    }

}
