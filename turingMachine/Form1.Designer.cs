namespace turingMachine
{
    partial class turingMachineProcess
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(turingMachineProcess));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goToPalindrome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goToCopyOfPatterns = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.goToSum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.goToSubtraction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.goToMultiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // goToPalindrome
            // 
            resources.ApplyResources(this.goToPalindrome, "goToPalindrome");
            this.goToPalindrome.Name = "goToPalindrome";
            this.goToPalindrome.UseVisualStyleBackColor = true;
            this.goToPalindrome.Click += new System.EventHandler(this.goToPalindrome_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // goToCopyOfPatterns
            // 
            resources.ApplyResources(this.goToCopyOfPatterns, "goToCopyOfPatterns");
            this.goToCopyOfPatterns.Name = "goToCopyOfPatterns";
            this.goToCopyOfPatterns.UseVisualStyleBackColor = true;
            this.goToCopyOfPatterns.Click += new System.EventHandler(this.goToCopyOfPatterns_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // goToSum
            // 
            resources.ApplyResources(this.goToSum, "goToSum");
            this.goToSum.Name = "goToSum";
            this.goToSum.UseVisualStyleBackColor = true;
            this.goToSum.Click += new System.EventHandler(this.goToSum_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // goToSubtraction
            // 
            resources.ApplyResources(this.goToSubtraction, "goToSubtraction");
            this.goToSubtraction.Name = "goToSubtraction";
            this.goToSubtraction.UseVisualStyleBackColor = true;
            this.goToSubtraction.Click += new System.EventHandler(this.goToSubtraction_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // goToMultiplication
            // 
            resources.ApplyResources(this.goToMultiplication, "goToMultiplication");
            this.goToMultiplication.Name = "goToMultiplication";
            this.goToMultiplication.UseVisualStyleBackColor = true;
            this.goToMultiplication.Click += new System.EventHandler(this.goToMultiplication_Click);
            // 
            // turingMachineProcess
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goToMultiplication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goToSubtraction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goToSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goToCopyOfPatterns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goToPalindrome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "turingMachineProcess";
            this.Load += new System.EventHandler(this.turingMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goToPalindrome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goToCopyOfPatterns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goToSum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goToSubtraction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button goToMultiplication;
    }
}

