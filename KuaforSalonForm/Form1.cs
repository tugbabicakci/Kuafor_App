using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using HairDesigner.Dll;
using HandAndFoot.Dll;
using HandAndFootAbstract.Dll;
using KuaforCostumer;

using SacTasarım.Dll;



namespace KuaforSalonForm
{
    public partial class Form1 : Form
    {
        ImageProxy proxy = new ImageProxy();
        Director director=new Director();
      
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(new Costum().CostumMethod(new ModernFactory()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new Costum().CostumMethod(new ClassicFactory()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
            label2.Text = KuaforSalonName_Singleton.Instance.GetName();

            MessageBox.Show(KuaforSalonName_Singleton.Instance.GetName());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            TopuzModelTasarım t = new DugunTopuz();

            director.Call(t);
            Product p1 = t.ProductGetResult();

            foreach (var p in p1.Show())
            {
                MessageBox.Show(p);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TopuzModelTasarım t = new DagınıkTopuz();

            director.Call(t);
            Product p1 = t.ProductGetResult();

            foreach (var p in p1.Show())
            {
                MessageBox.Show(p);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Costumer costumer=new Costumer();
            costumer.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show(new NailClient().ClientMethod(new NailArtConcreate()));


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(new NailClient().ClientMethod(new NailPaintConcreate()));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var factory = new HandAndFoot.Dll.ModernFactory();
            var m = factory.CreateNail();
            var a = factory.CreateSkinCare();
            string s = m.NailArt() + "-daha sonrasında-" + a.SkinCare();
            MessageBox.Show(s);

            




            /*
            MemoApp memoApp =new MemoApp();

            var name = "tugba";
            var sonuc = memoApp.Test(name);
            MessageBox.Show(sonuc);
            MessageBox.Show(name);

            var clients = new List<KuaforCostumer.Client>();
            for (int i = 0; i < 10; i++)
            {
                var client = new Client("tugba","bicakci "+i);
                clients.Add(client);
            }

            MessageBox.Show(clients[3].GetFullName());


            var updatedClients = memoApp.Test(clients);

            foreach (var updatedClient in updatedClients)
            {
                MessageBox.Show(updatedClient.GetFullName());
            }

            foreach (var originalClient in clients)
            {
                MessageBox.Show(originalClient.GetFullName());
            }
            */
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OdemeIslem o=new OdemeIslem();
            o.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
         SacKesimBoya sacKesimBoya=new KesimOmbre(new DuzSacKesim());

         MessageBox.Show(sacKesimBoya.BoyamaIslemi());
        

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SacKesimBoya sacKesimBoya=new KesimIsilti(new DuzSacKesim());

            MessageBox.Show(sacKesimBoya.BoyamaIslemi());

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SacKesimBoya sac=new KesimOmbre(new KatliSacKesim());

            MessageBox.Show(sac.BoyamaIslemi());
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            CompositeCalisan gm=new CompositeCalisan("t1","b1",enPozisyon.GenelMudur);

            CompositeCalisan root=new CompositeCalisan("Tuğba","bb",enPozisyon.Mudur);
            root.Ekle(new LeafCalisan("t1","b1",enPozisyon.Isci));
            root.Ekle(new LeafCalisan("t2","b2",enPozisyon.Isci));
           
            gm.Ekle(root);


            MessageBox.Show(gm.Goster());



        }

        private void button15_Click(object sender, EventArgs e)
        {
            SalonSil sil=new SalonSil();
            SalonSupur supur=new SalonSupur();
            SalonMalzemeBakım bakim=new SalonMalzemeBakım();

            SalonKapanisİslemleri kapanis=new SalonKapanisİslemleri(supur,sil,bakim);

            MessageBox.Show(kapanis.Operations());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            pictureBox1.Image = Image.FromFile(proxy.ShowImage());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            /*zinciri oluşturacak halkaları tanımlıyoruz*/
            PlayerHandler mp4Player = new ConcreteHandlerMp4();
            PlayerHandler mpgPlayer = new ConcreteHandlerMpg();
            PlayerHandler aviPlayer = new ConcreteHandlerAvi();

            /*Zincirin halkalarını sıralıyoruz */
            /*İstek hangi sıra ile ConcreteHandler sınıflarına iletileceğini belirliyoruz*/
            mp4Player.SonrakiHandler = mpgPlayer;
            mpgPlayer.SonrakiHandler = aviPlayer;

            /*İstekleri zincirin ilk halkasına gönderiyoruz*/
          MessageBox.Show(mp4Player.Play("video.mpg")) ;
            MessageBox.Show(mp4Player.Play("video.avi"));
            MessageBox.Show(mp4Player.Play("video.mp4"));
            MessageBox.Show(mp4Player.Play("video.swf"));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TakimConcreteAggregate TakimCollection = new TakimConcreteAggregate();
            TakimCollection.Add(new Takim { TakimAdi = "XXX Spor", Puan = 59 });
            TakimCollection.Add(new Takim { TakimAdi = "LALA Spor", Puan = 9 });
            TakimCollection.Add(new Takim { TakimAdi = "TEYTEY Spor", Puan = 10 });
            ITakimIterator itr = TakimCollection.GetIterator();
            while (itr.IsDone())
            {
                MessageBox.Show( itr.CurrentItem().TakimAdi+ itr.CurrentItem().Puan);
                itr.Next();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //İlk olarak Subject nesnemizi oluşturuyoruz.
            absUrun Kitap = new Urun("KitapXX", 10.25M);
            //Subject nesnemiz ile ilgili olan Uye (observer) listesine nesne ekliyoruz.
            Kitap.TakipList.Add(new Uye { E_Mail = "a@a.com" });
            Kitap.TakipList.Add(new Uye { E_Mail = "b@b.com" });
            //Subject yani ürün fiyatını değiştirdiğimizde listedeki
            //observer nesnelerinin ilgili metodu çalıştırılacak
            Kitap.Fiyat = 3.14M;

            Uye uye=new Uye();
            uye.E_Mail = "tugba@gdsfg";
            Uye uye2=new Uye();
            uye.E_Mail = "xxx@..";

            MessageBox.Show(uye.Update(Kitap));
            MessageBox.Show(uye2.Update(Kitap));
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var context = new Context();

            MessageBox.Show("Client: Strategy Sort() !");
            context.SetStrategy(new ConcreteStrategyA());
            MessageBox.Show(context.DoSomeBusinessLogic());


           MessageBox.Show("Client: Strategy Reverse()");
            context.SetStrategy(new ConcreteStrategyB());
            MessageBox.Show(context.DoSomeBusinessLogic());
        }
    }
}
