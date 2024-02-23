namespace veriYapilariUygulama
{
    internal class veriYapilariUygulama
    {

        static Liste tyb = new Liste();
        static Tree bst = new Tree();
        int key;
        int secim = menu1();
        int sayi;
        int indis;


        static void Main(string[] args)
        {



            int secim1;

            do
            {
                secim1 = menu1();

                switch (secim1)
                {
                    case 1:
                        menu2();
                        break;
                    case 2:
                        menu3();
                        break;
                    case 3:
                        menu4();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız !");
                        break;
                }
            } while (secim1 != 0);
        }




        private static int menu1()
        {
            Console.WriteLine("-- Uygulama Menüsü --");
            Console.WriteLine("");
            Console.WriteLine("1- Tek Yönlü Doğrusal Bağlı Liste");
            Console.WriteLine("2- İkili Arama Ağacı");
            Console.WriteLine("3- Hash Tablosu");
            Console.WriteLine("0- Çıkış");
            Console.Write("Seçiminiz : ");
            return int.Parse(Console.ReadLine());
        }

        private static void menu2()
        {
            int secim2;

            do
            {
                Console.WriteLine("-- Tek Yönlü Doğrusal Bağlı Liste Menü --");
                Console.WriteLine("");
                Console.WriteLine("1- Başa Ekle");
                Console.WriteLine("2- Sona Ekle");
                Console.WriteLine("3- Araya Ekle");
                Console.WriteLine("4- Baştan Sil");
                Console.WriteLine("5- Sondan Sil");
                Console.WriteLine("6- Aradan Sil");
                Console.WriteLine("7- Düğüm Sayısı");
                Console.WriteLine("8- Yazdır");
                Console.WriteLine("9- Tersten Yazdır");
                Console.WriteLine("10- Ortalama Değer");
                Console.WriteLine("11- Tekrarlanan Düğüm ve Tekrar Sayısı");
                Console.WriteLine("12- Ortanca Düğüm");
                Console.WriteLine("0- Önceki Menü");
                Console.Write("Seçiminiz : ");
                secim2 = int.Parse(Console.ReadLine());

                switch (secim2)
                {
                    case 1:
                        // Başa Ekle İşlemi
                        Console.Write("Başa eklemek istediğiniz değeri girin: ");
                        int sayi = int.Parse(Console.ReadLine());
                        tyb.basaEkle(sayi);
                        tyb.yazdir();
                        break;

                        break;
                    case 2:
                        // Sona Ekle işlemi
                        Console.Write("Sayı : ");
                        int sayi2 = int.Parse(Console.ReadLine());
                        tyb.sonaEkle(sayi2);
                        tyb.yazdir();
                        break;
                    case 3:

                        Console.Write("İndis : ");
                        int indis = int.Parse(Console.ReadLine());
                        Console.Write("Sayı : ");
                        sayi = int.Parse(Console.ReadLine());
                        tyb.arayaEkle(indis, sayi);
                        tyb.yazdir();
                        break;
                    case 4:
                        tyb.bastanSil();
                        tyb.yazdir();
                        break;
                    case 5:
                        tyb.sondanSil();
                        tyb.yazdir();
                        break;
                    case 6:
                        Console.Write("İndis : ");
                        indis = int.Parse(Console.ReadLine());
                        tyb.aradanSil(indis);
                        tyb.yazdir();
                        break;
                    case 7:
                        int dugumSayisi = tyb.ElemanSay();
                        Console.WriteLine("Düğüm Sayısı: " + dugumSayisi);
                        tyb.yazdir();
                        break;
                    case 8:
                        tyb.yazdir();
                        break;
                    case 9:
                        tyb.terstenYazdir();
                        break;
                    case 10:
                        float ortalama = tyb.HesaplaOrtalama();
                        Console.WriteLine("Düğümlerin Ortalaması: " + ortalama);
                        break;
                    case 11:
                        tyb.TekrarlananDugumler();
                        break;
                    case 12:
                        tyb.BulVeYazdirOrtancaDugum();
                        break;

                    case 0:

                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız !");
                        break;
                }
            } while (secim2 != 0);
        }

        private static void menu3()
        {
            int secim3;

            do
            {

                Console.WriteLine("-- İkili Arama Ağacı Menü --");
                Console.WriteLine("");
                Console.WriteLine("1- Dügüm Ekle");
                Console.WriteLine("2- Dügüm Sil");
                Console.WriteLine("3- Dügümleri Sırala");
                Console.WriteLine("4-Tekrarlanan Dügümü ve Tekrar Sayısını Bul");
                Console.WriteLine("5- En Küçük Değerli Dügüm");
                Console.WriteLine("6- En Büyük Değerli Dügüm");
                Console.WriteLine("7- Ortanca Düğüm");
                Console.WriteLine("8- Ortalama Değer");
                Console.WriteLine("9- Ağaç Yüksekliği");
                Console.WriteLine("10- Ağaç Düzeyi");
                Console.WriteLine("0- Önceki Menü");
                Console.Write("Seçiminiz : ");
                secim3 = int.Parse(Console.ReadLine());

                switch (secim3)
                {
                    case 1:
                        Console.Write("Ağaca Eklenecek Sayıyı Giriniz : ");
                        int sayi = int.Parse(Console.ReadLine());
                        bst.root = bst.DugumEkle(bst.root, sayi);
                        break;
                    case 2:
                        Console.Write("Ağaçtan Silinecek Sayıyı Giriniz : ");
                        sayi = int.Parse(Console.ReadLine());
                        bst.root = bst.DugumSil(bst.root, sayi);
                        break;
                    case 3:
                        Console.Write("Düğüm Sıralaması : ");
                        bst.inOrder(bst.root);
                        Console.WriteLine(" ");
                        break;

                    case 4:
                        bst.BulVeYazdirTekrarlananDugumler();
                        break;
                    case 5:
                        int enkucukdeger = bst.EnKucukDeger();
                        Console.WriteLine("Ağaçtaki En Küçük Değer: " + enkucukdeger);
                        break;
                    case 6:
                        int enbuyukdeger = bst.EnBuyukDeger();
                        Console.WriteLine("Ağaçtaki En Büyük Değer: " + enbuyukdeger);
                        break;
                    case 7:
                        bst.OrtancaDugum();
                        break;
                    case 8:
                        float avgVal = bst.AgacOrt();
                        Console.WriteLine("Ağaçtaki Düğümlerin Ortalaması: " + avgVal);
                        break;
                    case 9:
                        Console.WriteLine("Ağaç Yüksekliği : " + bst.yukseklik(bst.root));

                        break;
                    case 10:
                        Console.WriteLine("Ağaç Düzeyi : " + bst.duzey(bst.root));
                        break;

                    case 0:

                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız !");
                        break;
                }
            } while (secim3 != 0);

        }

        private static void menu4()
        {
            int secim4;

            Console.Write("Hash tablo boyutu: ");
            int size = int.Parse(Console.ReadLine());
            Tablo hashTablosu = new Tablo(size);

            do
            {

                Console.WriteLine("-- Hash Tablosu Menü --");
                Console.WriteLine("");
                Console.WriteLine("1- Düğüm Ekle");
                Console.WriteLine("2- Düğüm Sil");
                Console.WriteLine("3- Tablo Yazdır");
                Console.WriteLine("4- Dügüm Bul");
                Console.WriteLine("5- Dügümleri Sirala");
                Console.WriteLine("0- Önceki Menü");
                Console.Write("Seçiminiz : ");
                secim4 = int.Parse(Console.ReadLine());

                switch (secim4)
                {
                    case 1:
                        Console.Write("Sayı: ");
                        int key = int.Parse(Console.ReadLine());
                        hashTablosu.Ekle(key);
                        break;
                    case 2:
                        Console.Write("Sayı: ");
                        int silinecekKey = int.Parse(Console.ReadLine());
                        hashTablosu.Sil(silinecekKey);
                        break;
                    case 3:
                        hashTablosu.Yazdir();
                        break;
                    case 4:
                        Console.Write("Sayı: ");
                        int bulunacakKey = int.Parse(Console.ReadLine());
                        int bulunanIndis = hashTablosu.DugumBul(bulunacakKey);
                        if (bulunanIndis != -1)
                        {
                            Console.WriteLine($"{bulunacakKey} Numaralı düğüm, Tablo[{bulunanIndis}] indisinde bulundu.");
                        }
                        break;
                    case 5:
                        hashTablosu.DugumleriSirala();
                        Console.WriteLine("Düğümler küçükten büyüğe sıralandı.");
                        hashTablosu.Yazdir();
                        break;

                    case 0:
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız !");
                        break;
                }
            } while (secim4 != 0);

        }







        class Node
        {
            public int data;
            public Node next;
            public Node left;
            public Node right;



            public Node(int d)
            {
                data = d;
                next = null;
                left = null;
                right = null;

            }
        }
        class Liste
        {
            Node head;
            Node tail;

            public Liste()
            {
                head = null;
                tail = null;
            }
            public void basaEkle(int data)
            {
                Node eleman = new Node(data);
                if (head == null)
                {
                    head = eleman;
                    Console.WriteLine("Düğüm Oluşturuldu ve İlk Eleman Eklendi");
                }
                else
                {
                    eleman.next = head;
                    head = eleman;
                    Console.WriteLine("Başa " + data + " Değeri Eklendi. ");
                }


            }
            public void sonaEkle(int data)
            {
                Node eleman = new Node(data);
                if (head == null)
                {
                    head = eleman;
                    Console.WriteLine("Liste Oluşturuldu ve ilk Eleman Eklendi");
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = eleman; // Geçici düğümün snuna ekledi
                    Console.WriteLine("Sona " + data + " Değeri Eklendi ");
                }
            }

            public void arayaEkle(int indis, int data)
            {
                Node eleman = new Node(data);
                bool islemgerceklestimi = false;

                if (head == null && indis == 0)
                {
                    head = eleman;
                    Console.WriteLine("Liste Oluşturuldu ve ilk Eleman Eklendi");
                    islemgerceklestimi = true;
                }
                else if (head != null && indis == 0)
                {
                    basaEkle(data);
                    islemgerceklestimi = true;
                }
                else
                {
                    int i = 0;
                    Node temp = head;
                    Node tempinoncesi = temp;
                    while (temp.next != null)
                    {
                        if (i == indis)
                        {
                            islemgerceklestimi = true;
                            tempinoncesi.next = eleman;
                            eleman.next = temp;
                            i++;
                            Console.WriteLine("Listenin " + indis + ". İndisine " + data + " Değeri Eklendi");
                            break;
                        }
                        tempinoncesi = temp;
                        temp = temp.next;
                        i++;
                    }

                    if (i == indis)
                    {
                        islemgerceklestimi = true;
                        tempinoncesi.next = eleman;
                        eleman.next = temp;
                    }
                    if (temp.next == null && i + 1 == indis)
                    {
                        sonaEkle(data);
                        islemgerceklestimi = true;
                    }

                    if (islemgerceklestimi == false)
                    {
                        Console.WriteLine("Hatalı İndis Seçimi Yaptınız");
                    }
                }
            }

            public void bastanSil()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                }
                else if (head.next == null)
                {
                    head = null;
                    Console.WriteLine("Listede Kalan Son Elemanı Sildiniz");
                }
                else
                {
                    head = head.next;
                    Console.WriteLine("Baştan Eleman Silindi"); ;
                }
            }
            public void sondanSil()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                }
                else if (head.next == null)
                {
                    head = null;
                    Console.WriteLine("Listede Kalan Son Elemanı Sildiniz");
                }
                else
                {
                    Node temp = head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        temp2 = temp;
                        temp = temp.next;
                    }
                    temp2.next = null;
                    Console.WriteLine("Sondan Eleman Silindi");
                }
            }

            public void aradanSil(int indis)
            {
                bool sonuc = false;
                if (head == null)
                {
                    sonuc = true;
                    Console.WriteLine("Liste Boş");
                }
                else if (head.next == null && indis == 0)
                {
                    sonuc = true;
                    head = null;
                    Console.WriteLine("Listede Kalan Son Elemanı Sildiniz");
                }
                else if (head.next != null && indis == 0)
                {
                    sonuc = true;
                    bastanSil();
                }
                else
                {
                    int i = 0;
                    Node temp = head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        if (i == indis)
                        {
                            sonuc = true;
                            temp2.next = temp.next;
                            Console.WriteLine("Aradan Eleman Silindi");
                            i++;
                            break;
                        }
                        temp2 = temp;
                        temp = temp.next;
                        i++;
                    }
                    if (i == indis)
                    {
                        // sondanSil();
                        sonuc = true;
                        temp2.next = null;
                        Console.WriteLine("Aradan Eleman Silindi");
                        i++;
                    }
                }
                if (sonuc == false)
                {
                    Console.WriteLine("Hatalı indis SEçimi");
                }
            }



            public void yazdir()
            {
                Node temp = head;
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                }
                else
                {
                    Console.Write("Baş -> ");
                    while (temp.next != null)
                    {
                        Console.Write(temp.data + " -> ");
                        temp = temp.next;
                    }
                    Console.WriteLine(temp.data + " Son");
                }
            }

            public int ElemanSay()
            {
                int sayac = 0;
                Node temp = head;
                while (temp != null)
                {
                    sayac++;
                    temp = temp.next;
                }
                return sayac;
            }



            public void terstenYazdir(Node current)
            {
                if (current == null)
                    return;

                terstenYazdir(current.next);
                Console.Write(current.data + " ");
            }

            public void terstenYazdir()
            {
                Console.Write("Sondan Başa Doğru Yazdır: ");
                terstenYazdir(head);
                Console.WriteLine();
            }


            public float HesaplaOrtalama()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                    return 0;
                }

                Node current = head;
                int toplam = 0;
                int dugumSayisi = 0;

                while (current != null)
                {
                    toplam += current.data;
                    dugumSayisi++;
                    current = current.next;
                }

                return (float)toplam / dugumSayisi;
            }
            public void TekrarlananDugumler()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                    return;
                }

                Dictionary<int, int> dugumSayilari = new Dictionary<int, int>();
                Node current = head;

                while (current != null)
                {
                    if (dugumSayilari.ContainsKey(current.data))
                    {
                        dugumSayilari[current.data]++;
                    }
                    else
                    {
                        dugumSayilari[current.data] = 1;
                    }

                    current = current.next;
                }

                bool tekrarVarMi = false;
                Console.WriteLine("Tekrarlanan Düğümler ve Tekrar Sayıları:");
                foreach (var kvp in dugumSayilari)
                {
                    if (kvp.Value > 1)
                    {
                        Console.WriteLine($"Düğüm: {kvp.Key}, Tekrar Sayısı: {kvp.Value}");
                        tekrarVarMi = true;
                    }
                }

                if (!tekrarVarMi)
                {
                    Console.WriteLine("Tekrarlanan Düğüm Bulunamadı.");
                }
            }
            public void BulVeYazdirOrtancaDugum()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste Boş");
                    return;
                }

                Node slowPtr = head;
                Node fastPtr = head;
                Node prevSlowPtr = null;

                while (fastPtr != null && fastPtr.next != null)
                {
                    prevSlowPtr = slowPtr;
                    slowPtr = slowPtr.next;
                    fastPtr = fastPtr.next.next;
                }

                Console.Write("Ortanca Düğüm(ler): ");
                Console.Write(slowPtr.data + " ");

                if (fastPtr == null)
                {
                    // Düğüm sayısı çiftse bir önceki düğümü de yazdır
                    Console.Write(prevSlowPtr.data);
                }

                Console.WriteLine();
            }

        }



        // İkili Arama Ağacı
        class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node newNode(int data)
            {
                root = new Node(data);
                return root;
            }
            public Node DugumEkle(Node root, int data)
            {
                Node eleman = new Node(data);
                if (root != null)
                {
                    if (data < root.data)
                    {
                        root.left = DugumEkle(root.left, data);
                    }
                    else
                    {
                        root.right = DugumEkle(root.right, data);
                    }
                }
                else
                {
                    root = newNode(data);
                }
                return root;
            }
            public Node DugumSil(Node root, int s)
            {
                Node temp1, temp2;

                if (root == null) // Kök Yok Ağaç Yok
                {
                    return null;
                }
                if (root.data == s) // Kök Silinecek ama Gerisi nasıl olacak?
                {
                    if (root.left == root.right) // Silinecek Düğümün altında dal yok
                    {
                        root = null;
                        return null;
                    }
                    else if (root.left == null) // Kkün sağında düğüm var
                    {
                        temp1 = root.right;
                        return temp1;
                    }
                    else if (root.right == null) // Kökün solunda düğüm var
                    {
                        temp1 = root.left;
                        return temp1;
                    }
                    else // Kökün altında iki düğüm var
                    {
                        temp1 = temp2 = root.right;
                        while (temp1.left != null)
                        {
                            temp1 = temp1.left;
                        }
                        temp1.left = root.left;
                        return temp2;
                    }
                }
                else
                {
                    if (s < root.data)
                    {
                        root.left = DugumSil(root.left, s);
                    }
                    else
                    {
                        root.right = DugumSil(root.right, s);
                    }
                }
                return root;

            }

            public void inOrder(Node root)
            {
                if (root != null)
                {
                    inOrder(root.left);
                    Console.Write(root.data + " ");
                    inOrder(root.right);
                }
            }

            public int yukseklik(Node root)
            {
                if (root == null)
                {
                    return -1;
                }
                else
                {
                    int l, r;
                    l = yukseklik(root.left);
                    r = yukseklik(root.right);

                    if (l > r)
                    {
                        return l + 1;
                    }
                    else
                    {
                        return r + 1;
                    }
                }
            }

            public int duzey(Node root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    int l, r;
                    l = duzey(root.left);
                    r = duzey(root.right);

                    if (l > r)
                    {
                        return l + 1;
                    }
                    else
                    {
                        return r + 1;
                    }
                }
            }


            public float AgacOrt()
            {
                int sum = 0;
                int dugumsayisi = 0;
                AgacOrt(root, ref sum, ref dugumsayisi);

                if (dugumsayisi == 0)
                {
                    Console.WriteLine("Ağaç boş!");
                }

                return (float)sum / dugumsayisi;
            }

            void AgacOrt(Node root, ref int sum, ref int dugumsayisi)
            {
                if (root != null)
                {
                    AgacOrt(root.left, ref sum, ref dugumsayisi);
                    sum += root.data;
                    dugumsayisi++;
                    AgacOrt(root.right, ref sum, ref dugumsayisi);
                }
            }

            public void OrtancaDugum()
            {
                List<Node> middleNodes = new List<Node>();
                int totalCount = DugumSayisi(root);

                OrtancaDugumRecursive(root, ref middleNodes, ref totalCount, 0);

                Console.Write("Ortanca Düğüm(ler): ");
                foreach (var node in middleNodes)
                {
                    Console.Write(node.data + " ");
                }
                Console.WriteLine();
            }

            private int DugumSayisi(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                return DugumSayisi(root.left) + DugumSayisi(root.right) + 1;
            }

            private void OrtancaDugumRecursive(Node root, ref List<Node> middleNodes, ref int totalCount, int currentCount)
            {
                if (root != null)
                {
                    OrtancaDugumRecursive(root.left, ref middleNodes, ref totalCount, currentCount);

                    currentCount++;

                    if (totalCount % 2 == 1 && currentCount == totalCount / 2 + 1)
                    {
                        // Tek sayıda düğüm varsa ve ortanca düğümü geçtik
                        middleNodes.Clear();
                        middleNodes.Add(root);
                    }
                    else if (totalCount % 2 == 0 && (currentCount == totalCount / 2 || currentCount == totalCount / 2 + 1))
                    {
                        // Çift sayıda düğüm varsa ve ortanca iki düğümü geçtik
                        middleNodes.Add(root);
                    }

                    OrtancaDugumRecursive(root.right, ref middleNodes, ref totalCount, currentCount);
                }
            }









            public int EnKucukDeger()
            {
                return EnKucukDeger(root);
            }

            int EnKucukDeger(Node root)
            {
                if (root == null)
                {
                    Console.WriteLine("Ağaç Boş!");
                }

                while (root.left != null)
                {
                    root = root.left;
                }

                return root.data;
            }

            public int EnBuyukDeger()
            {
                return EnBuyukDeger(root);
            }

            int EnBuyukDeger(Node root)
            {
                if (root == null)
                {
                    Console.WriteLine("Ağaç boş!");
                }

                while (root.right != null)
                {
                    root = root.right;
                }

                return root.data;
            }

            public void BulVeYazdirTekrarlananDugumler()
            {
                if (root == null)
                {
                    Console.WriteLine("Ağaç Boş!");
                    return;
                }

                Dictionary<int, int> dugumSayilari = new Dictionary<int, int>();
                BulVeYazdirTekrarlananDugumler(root, dugumSayilari);

                bool tekrarVarMi = false;
                Console.WriteLine("Tekrarlanan Düğümler ve Tekrar Sayıları:");
                foreach (var kvp in dugumSayilari)
                {
                    if (kvp.Value > 1)
                    {
                        Console.WriteLine($"Düğüm: {kvp.Key}, Tekrar Sayısı: {kvp.Value}");
                        tekrarVarMi = true;
                    }
                }

                if (!tekrarVarMi)
                {
                    Console.WriteLine("Tekrarlanan Düğüm Bulunamadı.");
                }
            }

            private void BulVeYazdirTekrarlananDugumler(Node root, Dictionary<int, int> dugumSayilari)
            {
                if (root != null)
                {
                    BulVeYazdirTekrarlananDugumler(root.left, dugumSayilari);

                    if (dugumSayilari.ContainsKey(root.data))
                    {
                        dugumSayilari[root.data]++;
                    }
                    else
                    {
                        dugumSayilari[root.data] = 1;
                    }

                    BulVeYazdirTekrarlananDugumler(root.right, dugumSayilari);
                }
            }
        }

    }
    class Node_İki
    {
        public int key;
        public Node_İki next;

        public Node_İki()
        {
            next = null;
        }

        public Node_İki(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
    class Tablo
    {
        int size;
        public Node_İki[] dizi;

        public Tablo(int size)
        {
            this.size = size;
            dizi = new Node_İki[size];
            for (int i = 0; i < size; i++)
            {
                dizi[i] = new Node_İki();
            }
        }

        public int IndexUret(int key)
        {
            return key % size;
        }

        public void Ekle(int key)
        {
            Node_İki eleman = new Node_İki(key);
            int indis = IndexUret(key);
            Node_İki temp = dizi[indis];
            if (temp.next == null)
            {
                temp.next = eleman;
                Console.WriteLine("Tablonun " + indis + " . İndisine ilk değer olarak " + key + " Eklendi.");
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
                Console.WriteLine("Tablonun " + indis + " . İndisine " + key + " Değeri eklendi.");
            }
        }

        public void Sil(int key)
        {
            bool sonuc = false;
            int indis = IndexUret(key);
            Node_İki temp = dizi[indis];
            if (temp.next == null)
            {
                Console.WriteLine(indis + " İndisinde bir kayıt yok");
                sonuc = true;
            }
            else if (temp.next.next == null)
            {
                temp.next = null;
                Console.WriteLine(key + " Numaralı düğüm silindi");
                sonuc = true;
            }
            else
            {
                Node_İki temp2 = temp;
                while (temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                    if (temp.key == key)
                    {
                        temp2.next = temp.next;
                        Console.WriteLine(key + " Numaralı düğüm silindi");
                        sonuc = true;
                    }
                }
            }
            if (!sonuc)
            {
                Console.WriteLine(key + " Numaralı düğüm bulunamadı");
            }
        }

        public void Yazdir()
        {
            for (int i = 0; i < size; i++)
            {
                Node_İki temp = dizi[i];
                Console.Write("Tablo[{0}]->", i);
                while (temp.next != null)
                {
                    temp = temp.next;
                    Console.WriteLine(temp.key + " -> ");
                }
                Console.WriteLine();
            }
        }
        public int DugumBul(int key)
        {
            int indis = IndexUret(key);
            Node_İki temp = dizi[indis];

            int sayac = 0;

            while (temp.next != null)
            {
                temp = temp.next;
                if (temp.key == key)
                {
                    Console.WriteLine($"{key} Numaralı düğüm, Tablo[{indis}] indisinde bulundu.");
                    return indis;
                }
                sayac++;
            }

            Console.WriteLine($"{key} Numaralı düğüm bulunamadı.");
            return -1;
        }
        public void DugumleriSirala()
        {
            for (int i = 0; i < size; i++)
            {
                dizi[i] = Sirala(dizi[i]);
            }
        }

        private Node_İki Sirala(Node_İki head)
        {
            Node_İki current, index;
            int temp;

            if (head == null)
                return head;
            else
            {
                for (current = head; current.next != null; current = current.next)
                {
                    for (index = current.next; index != null; index = index.next)
                    {
                        if (current.key > index.key)
                        {
                            temp = current.key;
                            current.key = index.key;
                            index.key = temp;
                        }
                    }
                }
                return head;
            }
        }
    }
}