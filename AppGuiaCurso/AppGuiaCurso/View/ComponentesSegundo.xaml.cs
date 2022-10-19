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
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Inglês Instrumental",

                    AtribuicoesResponsabilidades = "Comunicar-se em lingua estrangeira",


                    ValoresAtitudes = "Respeitar manifestações culturais de outros povos",

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
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Analisar e projetar sistemas de informação, selecionando linguegens de programação e ambiente de desenvolvimento  de acordo com as especificidades do projeto",


                    ValoresAtitudes = "Fortalecer a persistencia e o interesse na resolução de situação-problema",

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
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "Implementar banco de dados",


                    ValoresAtitudes = "Incentivar a criatividade, desenvolver a criticidade",

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
                    Nome = "Internet e Protocolos",

                    AtribuicoesResponsabilidades = "utilizar protocolos de rede e internet para comunicação de dados",


                    ValoresAtitudes = "Incentivar comportamentos éticos, Promover ações que considerem o respeito a normas estabelecidas",

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
                    Nome = "Programação de Aplicativos Mobile I",

                    AtribuicoesResponsabilidades = "Elaborar projetos de aplicativos para plataformas moveis",


                    ValoresAtitudes = "Incentivar  a criatividade, responsabilizar-se pela produção, utilização e divulgação de informações",

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
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas de informação web",


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
                    Nome = "Planejamento do trabalho de Conclusão de curso (TCC)",

                    AtribuicoesResponsabilidades = "Planejar projetos de sistemas computacionais",


                    ValoresAtitudes = "Comunicarse em grupo com clareza e objetividade",

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