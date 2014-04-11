using System;

namespace RefactorExercise
{
    [Flags]
    public enum Weather : short
    {
        Null = 0,
        Sun = 1,
        Rain = 2,
        Snow = 4,
        Wind = 8,
        Storm = 16
    }

    public enum Balance
    {
        Negative,
        Zero,
        Positive
    }

    public class GeneralView
    {
        public DayOfWeek DayofWeek { get; set; }
        public Weather Weather { get; set; }
        public Balance Balance { get; set; }
    }

    public class DecomposeConditional
    {

        public GeneralView GeneralView { get; set; }

        public bool CanTakeVacation()
        {
            return !(GeneralView.Balance == Balance.Negative || GeneralView.Balance == Balance.Zero ||
                     (GeneralView.Balance == Balance.Positive &&
                      (GeneralView.Weather == Weather.Rain ||
                       GeneralView.Weather == (Weather.Rain | Weather.Snow)) &&
                      GeneralView.DayofWeek == DayOfWeek.Monday) || GeneralView.Weather == Weather.Storm);
        }
    }
}
