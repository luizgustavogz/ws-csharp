namespace Course25_HerançaMultipla.Devices {
    abstract class Device {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
