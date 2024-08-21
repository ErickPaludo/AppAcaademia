using Academy.Componentes.Exercicio;

namespace Academy;

public partial class Treino1 : ContentPage
{
	public Treino1()
	{
		InitializeComponent();

        // Criando e adicionando 5 componentes de maneira enxuta
        for (int i = 1; i <= 10; i++)
            Scroll.Children.Add(new Exercicio { ExercicioText = $"Treino {i}" });
    }

    private void Start(object sender, EventArgs e)
    {
        if(btnstr.Text.Equals("Iniciar") || btnstr.Text.Equals("Retornar"))
        {
            Scroll.IsEnabled = true;
            btnencerra.IsVisible = true;
            btnstr.Text = "Pausar";
        }
        else
        {
            Scroll.IsEnabled = false;
            btnencerra.IsVisible = false;
            btnstr.Text = "Retornar";
        }
    }
}