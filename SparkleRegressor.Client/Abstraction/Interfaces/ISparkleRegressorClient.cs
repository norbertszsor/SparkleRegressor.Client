using SparkleRegressor.Client.Abstraction.Query;

namespace SparkleRegressor.Client.Abstraction.Interfaces
{
    public interface ISparkleRegressorClient
    {
        Task<Dictionary<DateTime, double>?> GetPredictionAsync(GetPredictionCm cmQuery);
    }
}
