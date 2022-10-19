using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppGuiaCurso.Model;
namespace AppGuiaCurso.View


{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Segurança de Sistemas de Informação",

                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança de informação",


                    ValoresAtitudes = "estimular atitudes respeitosas, incentivar comportamentos éticos",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Banco de Dados III",

                    AtribuicoesResponsabilidades = "Realizar gestão de banco de dados",


                    ValoresAtitudes = "Incentivar a criatividade, desenvolver a criaticidade",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Sistemas embarcados",

                    AtribuicoesResponsabilidades = "Desenvolver sistemas embarcados",


                    ValoresAtitudes = "Fortalecer as persistências e o interesse na resolução de situação-problema",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação de Aplicativos Mobile II",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis",


                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Programação Web III",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação web",


                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Qualidade e Testes de software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria de qualidade de sistemas",


                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Ética e Cidadania Organizacional",

                    AtribuicoesResponsabilidades = "Atuar de acordo com principios éticos nas relações de trabalho",


                    ValoresAtitudes = "estimular atitudes respeitosas, Incentivar comportamentos éticos",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC)",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais",


                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas, demonstrar comprometimento com equipe e o trabalho",

                };
                await Navigation.PushAsync(new VerComponente(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}