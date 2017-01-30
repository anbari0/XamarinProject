
// This file has been generated by the GUI designer. Do not modify.
namespace Raspored
{
	public partial class DodajUcionicuWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entry_naziv;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entry_kapacitet;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entry_dodatniKomentar;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Button button_spremi;

		private global::Gtk.Button button_odustani;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Raspored.DodajUcionicuWindow
			this.WidthRequest = 400;
			this.HeightRequest = 300;
			this.Name = "Raspored.DodajUcionicuWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Dodaj učionicu");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("Raspored.Logo_smanjeni.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.BorderWidth = ((uint)(20));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Raspored.DodajUcionicuWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Unos informacija o učionici");
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			w1.Padding = ((uint)(5));
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.WidthRequest = 0;
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv:");
			this.hbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label2]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry_naziv = new global::Gtk.Entry();
			this.entry_naziv.CanFocus = true;
			this.entry_naziv.Name = "entry_naziv";
			this.entry_naziv.IsEditable = true;
			this.entry_naziv.ActivatesDefault = true;
			this.entry_naziv.InvisibleChar = '●';
			this.hbox1.Add(this.entry_naziv);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry_naziv]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.WidthRequest = 33;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Kapacitet:");
			this.hbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label3]));
			w5.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry_kapacitet = new global::Gtk.Entry();
			this.entry_kapacitet.CanFocus = true;
			this.entry_kapacitet.Name = "entry_kapacitet";
			this.entry_kapacitet.IsEditable = true;
			this.entry_kapacitet.InvisibleChar = '●';
			this.hbox2.Add(this.entry_kapacitet);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry_kapacitet]));
			w6.Position = 1;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 31;
			this.label4.Name = "label4";
			this.label4.Ypad = 1;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Dodatni komentar:");
			this.hbox3.Add(this.label4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label4]));
			w8.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry_dodatniKomentar = new global::Gtk.Entry();
			this.entry_dodatniKomentar.HeightRequest = 100;
			this.entry_dodatniKomentar.CanFocus = true;
			this.entry_dodatniKomentar.Name = "entry_dodatniKomentar";
			this.entry_dodatniKomentar.IsEditable = true;
			this.entry_dodatniKomentar.InvisibleChar = '●';
			this.hbox3.Add(this.entry_dodatniKomentar);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry_dodatniKomentar]));
			w9.Position = 1;
			this.vbox3.Add(this.hbox3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = -105;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button_spremi = new global::Gtk.Button();
			this.button_spremi.WidthRequest = 100;
			this.button_spremi.CanFocus = true;
			this.button_spremi.Name = "button_spremi";
			this.button_spremi.UseUnderline = true;
			this.button_spremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox4.Add(this.button_spremi);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button_spremi]));
			w11.Position = 0;
			w11.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.button_odustani = new global::Gtk.Button();
			this.button_odustani.WidthRequest = 100;
			this.button_odustani.CanFocus = true;
			this.button_odustani.Name = "button_odustani";
			this.button_odustani.UseUnderline = true;
			this.button_odustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox4.Add(this.button_odustani);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.button_odustani]));
			w12.Position = 1;
			w12.Fill = false;
			this.vbox3.Add(this.hbox4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w13.Position = 1;
			w13.Padding = ((uint)(10));
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 336;
			this.Show();
			this.button_spremi.Clicked += new global::System.EventHandler(this.OnButtonSpremiClicked);
			this.button_odustani.Clicked += new global::System.EventHandler(this.OnButtonOdustaniClicked);
		}
	}
}
