using System;

class Bola {
        private string cor;
        private double circunferencia;
        private string material;

        public string getCor() {
                return this.cor;
        }
        public void setCor(string cor) {
                this.cor = cor;
        }


        public double getCircunferencia() {
                return this.circunferencia;
        }

        public void setCircunferencia (double C) {
                this.circunferencia = C;
        }

        public string getMaterial() {
                return this.material;
        }

        public void setMaterial (string M) {
                this.material = M;
        }

}