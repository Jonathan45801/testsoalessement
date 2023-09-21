namespace soal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal hasilangka = Getangkafromtext("USOMAANAPAIUMASYDNIP", "SIAPA");
            Console.WriteLine(hasilangka);
        }
        public static int Getangkafromtext(string kalimat, string textdicari)
        {
            int angka = 0;
            string hurufsiapa = string.Empty;
            string totalkalimat = kalimat;
            int index = 0;
            List<string> hasilakhir = new List<string>();
            for (int bb = index; bb < kalimat.Length; bb++)
            {
                if (kalimat.Contains(textdicari[0]))
                {
                    for (int aa = 0; aa < textdicari.Length; aa++)
                    {
                        string hurufa = textdicari.Substring(aa, 1);
                        int angkat = totalkalimat.IndexOf(hurufa);
                        if (totalkalimat.Substring(angkat, 1) == hurufa)
                        {
                            hurufsiapa = hurufsiapa + hurufa;
                            if (hurufsiapa == textdicari)
                            {
                                hasilakhir.Add(hurufsiapa);
                                index += hurufsiapa.Length;
                                hurufsiapa = string.Empty;
                            }
                            totalkalimat = kalimat.Remove(angkat, 1);
                        }
                        kalimat = totalkalimat;
                    }
                }

            }
            return hasilakhir.Count();
        }
    }
}