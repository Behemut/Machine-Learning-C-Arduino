using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Core;
using Microsoft.Data.DataView;
using System.Collections;
using System.Windows.Forms;

namespace Prototipo_IO_Arduino
{
    public class Invernadero
    {
        [LoadColumn(0)]
        public float temperatura;

        [LoadColumn(1)]
        public float humedad;

        [LoadColumn(2)]
        public string Label;

    }



    public class Prediccion_Invernadero
    {
        float temperatura_actual;
        float humedad_rel;
        public float Temperatura_actual { get => temperatura_actual; set => temperatura_actual = value; }
        public float Humedad_rel { get => humedad_rel; set => humedad_rel = value; }


        [ColumnName("PredictedLabel")]
        public string PredictedLabels;


        public string Resultado_Prediccion()
        {
            var mlContext = new MLContext();
            var reader = mlContext.Data.CreateTextLoader<Invernadero>(separatorChar: '|', hasHeader: true);
            IDataView trainingDataView = reader.Read("datos.txt");
            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label")
              .Append(mlContext.Transforms.Concatenate("Features", "temperatura", "humedad"))
              .Append(mlContext.MulticlassClassification.Trainers.StochasticDualCoordinateAscent(labelColumn: "Label", featureColumn: "Features"))
              .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));
            var model = pipeline.Fit(trainingDataView);
            var prediction = model.CreatePredictionEngine<Invernadero, Prediccion_Invernadero>(mlContext).Predict(
                new Invernadero()
                {
                    temperatura = temperatura_actual,
                    humedad = humedad_rel,
                });
            return prediction.PredictedLabels;
        }
    }
}