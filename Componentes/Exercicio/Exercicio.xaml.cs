using Microsoft.Maui.Controls;

namespace Academy.Componentes.Exercicio
{
    public partial class Exercicio : ContentView
    {
        public Exercicio()
        {
            InitializeComponent();
        }

        private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Se o CheckBox estiver marcado, altere o texto e a cor
            if (e.Value)
            {
                exercicio.TextColor = Colors.Gray;
            }
            else
            {
                exercicio.TextColor = Colors.White;
            }
        }

        public static readonly BindableProperty ExercicioTextProperty =
            BindableProperty.Create(
                nameof(ExercicioText),
                typeof(string),
                typeof(Exercicio),
                default(string),
                propertyChanged: OnExercicioTextChanged);

        public string ExercicioText
        {
            get => (string)GetValue(ExercicioTextProperty);
            set => SetValue(ExercicioTextProperty, value);
        }

        public static readonly BindableProperty SeriesTextProperty =
            BindableProperty.Create(
                nameof(SeriesText),
                typeof(string),
                typeof(Exercicio),
                default(string),
                propertyChanged: OnSeriesTextChanged);

        public string SeriesText
        {
            get => (string)GetValue(SeriesTextProperty);
            set => SetValue(SeriesTextProperty, value);
        }

        private static void OnExercicioTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Exercicio)bindable;
            control.exercicio.Text = (string)newValue;
        }

        private static void OnSeriesTextChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Exercicio)bindable;
            control.series.Text = (string)newValue;
        }
    }
}
