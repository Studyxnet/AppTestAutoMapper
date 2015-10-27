using System;

using Xamarin.Forms;

namespace AppTestForFastMapper
{
    public class PessoaPage : ContentPage
    {
        Button btnAddPessoa;
        StackLayout mainLayout;
        Entry txtNomePessoa;
        Entry txtCpfPessoa;

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new PessoaViewModel();
        }

        public PessoaPage()
        {
            btnAddPessoa = new Button
            {
                Text = "Adicionar Pessoa",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            btnAddPessoa.SetBinding<PessoaViewModel>(Button.CommandProperty, b => b.Click_Adicionar_Pessoa);

            txtNomePessoa = new Entry
            {
                Placeholder = "Nome",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 220
            };
            txtNomePessoa.SetBinding<PessoaViewModel>(Entry.TextProperty, b => b.PessoaDto.Nome);

            txtCpfPessoa = new Entry
            {
                Placeholder = "CPF",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 220
            };
            txtCpfPessoa.SetBinding<PessoaViewModel>(Entry.TextProperty, b => b.PessoaDto.Cpf);

            mainLayout = new StackLayout
            {
                Spacing = 5,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 20, 0, 0),
                Children =
                {
                    txtNomePessoa,
                    txtCpfPessoa,
                    btnAddPessoa
                }
            };

            this.Content = mainLayout;
        }
    }
}


