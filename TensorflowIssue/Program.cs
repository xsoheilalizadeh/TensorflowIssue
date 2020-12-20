using System;
using Microsoft.ML;

namespace TensorflowIssue
{
    class Program
    {
        static void Main(string[] args)
        {
           var context = new MLContext();

          var model = context.Model.LoadTensorFlowModel("./model/saved_model.pb");
        }
    }
}
