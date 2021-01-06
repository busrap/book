using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        List<Kitap> kitaplar;
        int indexOfBook = -1;
        bool sonucAlaniBosMu = true;

        private void Form1_Load(object sender, EventArgs e) {
            ResetTheResultPlace();
            ResetAllButtons();

            kitaplar = new List<Kitap>();
        }

        void ResetTheResultPlace() {
            lblSonuc.Text = "-\n-\n-\n-";

            indexOfBook = -1;
        }

        void ResetAllButtons() {
            btnFirst.Enabled = false;
            btnBackward.Enabled = false;
            btnForward.Enabled = false;
            btnLast.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ResetAllRecordPlaces() {
            txtKitapAdi.Text = "";
            txtKitapTuru.Text = "";
            txtYazarAdi.Text = "";
            txtYazarSoyadi.Text = "";
        }

        private void btnKayitEt_Click(object sender, EventArgs e) {
            Kitap kitap = new Kitap();

            if(TumAlanlarDoluMu()) {
                kitap.KitapAdi = txtKitapAdi.Text;
                kitap.KitapTuru = txtKitapTuru.Text;
                kitap.YazarAdi = txtYazarAdi.Text;
                kitap.YazarSoyadi = txtYazarSoyadi.Text;

                if (SistemeKaydet(kitap)) {
                    kitaplar.Add(kitap);
                    MessageBox.Show("Kitap sisteme kayıt edildi...");
                } else {
                    MessageBox.Show("Girdiğiniz kitap adından sistemde daha önce bulunduğu için, sisteme kayıt yapamıyoruz...");
                    ResetAllRecordPlaces();
                }
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");

            ResetAllRecordPlaces();
            ControlButtons();
        }

        bool TumAlanlarDoluMu() {
            if (txtKitapAdi.Text != "" && txtKitapTuru.Text != "" && txtYazarAdi.Text != "" && txtYazarSoyadi.Text != "")
                return true;

            return false;
        }

        bool SistemeKaydet(Kitap kitap) {
            foreach (Kitap item in kitaplar) {
                if (item.KitapAdi == kitap.KitapAdi)
                    return false;
            }
            return true;
        }

        void ControlButtons() {
            if (sonucAlaniBosMu)
                btnDelete.Enabled = false;
            else
                btnDelete.Enabled = true;

            if (indexOfBook == 0) {
                btnFirst.Enabled = false;
                btnForward.Enabled = true;
                btnBackward.Enabled = false;
                btnLast.Enabled = true;
            } else if (indexOfBook == kitaplar.Count - 1) {
                btnFirst.Enabled = true;
                btnForward.Enabled = false;
                btnBackward.Enabled = true;
                btnLast.Enabled = false;
            }else if(indexOfBook > 0 && indexOfBook < kitaplar.Count - 1) {
                btnFirst.Enabled = true;
                btnForward.Enabled = true;
                btnBackward.Enabled = true;
                btnLast.Enabled = true;
            }

            if (kitaplar.Count > 0) {
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
            } else if(kitaplar.Count == 1) {
                btnForward.Enabled = false;
                btnBackward.Enabled = false;
            } else
                ResetAllButtons();
        }

        private void btnKayitAra_Click(object sender, EventArgs e) {
            if (txtAranacak.Text == "")
                MessageBox.Show("Lütfen arama alanını boş bırakmayınız...");
            else {
                foreach (Kitap item in kitaplar) {
                    if (item.KitapAdi.ToLower() == txtAranacak.Text.ToLower()) {
                        FillTheResultPlace(item);
                        sonucAlaniBosMu = false;
                    } else
                        MessageBox.Show("Aradığınız isimde bir kitap bulunamadı...");
                }
            }

            txtAranacak.Text = "";
        }

        void FillTheResultPlace(Kitap kitap) {
            lblSonuc.Text = kitap.KitapAdi + "\n" + kitap.KitapTuru + "\n" + kitap.YazarAdi + "\n" + kitap.YazarSoyadi;
        }

        private void btnFirst_Click(object sender, EventArgs e) {
            indexOfBook = 0;
            sonucAlaniBosMu = false;

            FillTheResultPlace(kitaplar[indexOfBook]);

            btnFirst.Enabled = false;
            btnBackward.Enabled = false;

            ControlButtons();
        }

        private void btnLast_Click(object sender, EventArgs e) {
            indexOfBook = kitaplar.Count - 1;
            sonucAlaniBosMu = false;

            FillTheResultPlace(kitaplar[indexOfBook]);

            btnLast.Enabled = false;
            btnForward.Enabled = false;

            ControlButtons();
        }

        private void btnBackward_Click(object sender, EventArgs e) {
            if (indexOfBook > 0) 
                indexOfBook--;

            sonucAlaniBosMu = false;

            FillTheResultPlace(kitaplar[indexOfBook]);
            ControlButtons();
        }

        private void btnForward_Click(object sender, EventArgs e) {
            if (indexOfBook < kitaplar.Count - 1) 
                indexOfBook++;

            sonucAlaniBosMu = false;

            FillTheResultPlace(kitaplar[indexOfBook]);
            ControlButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            kitaplar.RemoveAt(indexOfBook);

            if (kitaplar.Count - 1 >= 0) {
                indexOfBook = kitaplar.Count - 1;
                FillTheResultPlace(kitaplar[indexOfBook]);
            } else {
                btnDelete.Enabled = false;
                ResetTheResultPlace();
            }

            ControlButtons();
        }
    }
}
