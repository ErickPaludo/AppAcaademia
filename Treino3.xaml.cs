using Academy.Componentes.Exercicio;

namespace Academy;

public partial class Treino3 : ContentPage
{
	public Treino3()
	{
		InitializeComponent();
		 for (int i = 1; i <= 3; i++)
            Scroll.Children.Add(new Exercicio { ExercicioText = $"Tela3 * elemento {i}" });
	}
}