namespace NelnetProgrammingExercise.Models
{
    public class WeightModel
    {
        public float Floor { get; private set; }
        public float Ceiling { get; private set; }

        public WeightModel(float floor, float ceiling)
        {
            this.Floor = floor;
            this.Ceiling = ceiling;
        }

        public static WeightModel Create(WeightType weightType)
        {
            switch (weightType)
            {
                case WeightType.ExtraSmall:
                    return new WeightModel(0, 1);
                case WeightType.Small:
                    return new WeightModel(1, 5);
                case WeightType.Medium:
                    return new WeightModel(5, 15);
                case WeightType.Large:
                    return new WeightModel(15, 30);
                case WeightType.ExtraLarge:
                    return new WeightModel(30, float.MaxValue);
                default:
                    return null;
            }
        }
    }
}