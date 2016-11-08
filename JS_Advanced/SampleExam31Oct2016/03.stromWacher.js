(function () {

    let nextId = 0;

    return class Report {
        constructor(temperature, humidity, pressure, windSpeed) {
            this.id = nextId++;
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.windSpeed = windSpeed;
        }

        toString() {
            let weatter = 'Not stormy';
            if (this.temperature < 20 &&
                (this.pressure < 700 || this.pressure > 900) &&
                this.windSpeed > 25) {
                weatter = 'Stormy';
            }
            let result = `Reading ID: ${this.id}
Temperature: ${this.temperature}*C
Relative Humidity: ${this.humidity}%
Pressure: ${this.pressure}hpa
Wind Speed: ${this.windSpeed}m/s
Weather: ${weatter}`;
            return result;
        }
    }
})()
