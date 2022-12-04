namespace CurrencyConv;

public partial class MainPage : ContentPage
{
	string txt;

	public MainPage()
	{
		InitializeComponent();
	}

	void EntryData(object sender, EventArgs e)
	{
		txt = ((Entry)sender).Text;
	}

	void EntryTextChange(object sender, TextChangedEventArgs e)
	{
		txt = e.NewTextValue;
	}

	//functie conversie euro in lei
	private void OnCounterClicked(object sender, EventArgs e)
	{
		float value = float.Parse(txt);
		float Euro = 4.95F;
		value = value * Euro;
		Converter.Text = $"{value.ToString("0.00")} lei";

		SemanticScreenReader.Announce(Converter.Text);
	}
}

