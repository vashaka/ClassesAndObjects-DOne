using System;

namespace ClassesAndObjectsTask
{
    public class Car
    {
        private string brand;

        public Car() => this.brand = string.Empty;

        public Car(string brand)
        {
            this.brand = brand ?? throw new ArgumentNullException(nameof(brand), $"{nameof(brand)} can not be null");
        }

        public string GetCarBrand() => this.brand;
    }
}
