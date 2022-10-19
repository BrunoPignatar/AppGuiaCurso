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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componente
                {
                    Nome = "Linguagem, Trabalho e tecnologia",

                    AtribuicoesResponsabilidades = "Comunicar-se em língua portuguesa, utilizando o vocabulário técnico da área e" +
                                                   "elaborar registros e planilhas de acompanhamento e controle de atividades",

                    ValoresAtitudes = "Incentivar o diálogo e a interlocução. *Responsabiliza-se pela produção, utilização e " +
                                      "divulgação de informações. *Estimular a proatividade. ",
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
                    Nome = "Programação e algoritmos",

                    AtribuicoesResponsabilidades = "criar projetos usando a linguagem de programação",
                                                 

                    ValoresAtitudes = "Estimular a organização. *incentivar atitudes de autonomia",
                                     
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
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "Modelar Banco de Dados",


                    ValoresAtitudes = "Estimular a organização, fortalecer a persistência e o interesse na resolução de situação-problema, promover ações que considerem o respeito às normas estabelecidas",

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
                    Nome = "Análise e Projeto de sistemas",

                    AtribuicoesResponsabilidades = "Elaborar Projetos de sistema de informação",


                    ValoresAtitudes = "Estimular a organização, incentivar a criatividade, fortalecer a persistência e o interesse na resolução da situação-problema",

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
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites",


                    ValoresAtitudes = "Incentivar a criatividade, respeitar as manifestações culturais de outros povos, incentivar ações que promovam a cooperação",

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
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",


                    ValoresAtitudes = "Incentivar a criatividade, estimular a organização, fortalecer a persistência e o interesse na resolução de situação-problema",

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
                    Nome = "Fundamentos da Informatica",

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais",


                    ValoresAtitudes = "Desenvolver a criticidade, incentivar comportamentos éticos",

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
                    Nome = "Técnica de Programação",

                    AtribuicoesResponsabilidades = "Desenvolver programas de computador, utilizando principios de boas praticas" +
                    "*realizar versionamento no desenvolvimento de programas"


                    ValoresAtitudes = "Incentivar a criatividade, incentivar comportamentos éticos",

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