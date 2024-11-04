
using System;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace ChallengeChurnAnalytics.Services
{
    public class SentimentAnalysisService
    {
        private readonly MLContext _mlContext;
        private ITransformer _model;

        public SentimentAnalysisService()
        {
            _mlContext = new MLContext();
            LoadModel();
        }

        private void LoadModel()
        {
            var modelPath = "MLModels/sentiment_model.zip";
            if (File.Exists(modelPath))
            {
                DataViewSchema modelSchema;
                _model = _mlContext.Model.Load(modelPath, out modelSchema);
            }
        }

        public string PredictSentiment(string text)
        {
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(_model);
            var input = new SentimentData { Text = text };
            var result = predictionEngine.Predict(input);
            return result.Prediction ? "Positive" : "Negative";
        }
    }

    public class SentimentData
    {
        [LoadColumn(0)]
        public string Text;

        [LoadColumn(1), ColumnName("Label")]
        public bool Sentiment;
    }

    public class SentimentPrediction : SentimentData
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction;
    }
}
