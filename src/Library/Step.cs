//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Recipies
{
    public class Step : IJsonConvertible
    {
        [JsonConstructor]
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Step(string json)
        {
            this.LoadFromJson(json);
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public void LoadFromJson(string json)
        {
            Step newStep = JsonSerializer.Deserialize<Step>(json);
            this.Input = newStep.Input;
            this.Quantity = newStep.Quantity;
            this.Time = newStep.Time;
            this.Equipment = newStep.Equipment;

        }
        public string ConvertToJson()
        {
            return JsonSerializer.Serialize<Step>(this);
        }
    }
}