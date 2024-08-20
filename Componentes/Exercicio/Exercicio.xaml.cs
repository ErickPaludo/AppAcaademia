using Microsoft.Maui.Controls;

namespace Academy.Componentes.Exercicio
{
    public partial class Exercicio : ContentView
    {
        // BindableProperty para ExercicioText
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

        // BindableProperty para SeriesText
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

        public Exercicio()
        {
            InitializeComponent();
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
