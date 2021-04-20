using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace TestAssignment
{
    public enum Condition
    {
        EXCELLENT,
        GOOD,
        FAIR,
        BAD
    };

    public class Car
    {      
        public string Make;
        public Condition Condition;
        private int _speed;
        public int Speed
        {
            get { return _speed ;  }
            set { _speed = Convert.ToInt32(5 * Math.Round(value / 5.0)); }
        }

        public Car(string make, Condition con)
        {
            this.Make = make;
            this.Condition = con;
        } 
    }
    public class Function
    {
        
        public Car FunctionHandler(string input, ILambdaContext context)
        {
            
            Car chevy1 = new Car("chevy", Condition.EXCELLENT);
            return chevy1;
        }
    }
}
