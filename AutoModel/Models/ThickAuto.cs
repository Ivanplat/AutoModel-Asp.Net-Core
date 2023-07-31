namespace AutoModel.Models
{
    public class ThickAuto : Auto
    {
        public ThickAuto(string brand, string modelAuto, int engineCapacity) 
        {
            Brand = brand;
            ModelAuto = modelAuto;
            EngineCapacity = engineCapacity;
        }
        public string GetInfo()
        {
            return $"Наименование: {Brand}, Модель: {ModelAuto}, " +
               $"Объем двигателя: {EngineCapacity}";
        }
    }
}
