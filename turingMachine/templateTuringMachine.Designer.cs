namespace turingMachine
{
    partial class templateTuringMachine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_actualState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_stepsCounter = new System.Windows.Forms.Label();
            this.lbl_instruction = new System.Windows.Forms.Label();
            this.txt_instruction = new System.Windows.Forms.TextBox();
            this.btn_runMachine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unidad de control";
            // 
            // lbl_actualState
            // 
            this.lbl_actualState.AutoSize = true;
            this.lbl_actualState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actualState.Location = new System.Drawing.Point(240, 40);
            this.lbl_actualState.Name = "lbl_actualState";
            this.lbl_actualState.Size = new System.Drawing.Size(31, 24);
            this.lbl_actualState.TabIndex = 2;
            this.lbl_actualState.Text = "q0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de pasos";
            // 
            // lbl_stepsCounter
            // 
            this.lbl_stepsCounter.AutoSize = true;
            this.lbl_stepsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stepsCounter.Location = new System.Drawing.Point(835, 43);
            this.lbl_stepsCounter.Name = "lbl_stepsCounter";
            this.lbl_stepsCounter.Size = new System.Drawing.Size(20, 24);
            this.lbl_stepsCounter.TabIndex = 4;
            this.lbl_stepsCounter.Text = "0";
            // 
            // lbl_instruction
            // 
            this.lbl_instruction.AutoSize = true;
            this.lbl_instruction.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instruction.Location = new System.Drawing.Point(12, 9);
            this.lbl_instruction.Name = "lbl_instruction";
            this.lbl_instruction.Size = new System.Drawing.Size(145, 22);
            this.lbl_instruction.TabIndex = 5;
            this.lbl_instruction.Text = "Instrucción";
            // 
            // txt_instruction
            // 
            this.txt_instruction.Location = new System.Drawing.Point(164, 9);
            this.txt_instruction.Name = "txt_instruction";
            this.txt_instruction.Size = new System.Drawing.Size(499, 20);
            this.txt_instruction.TabIndex = 6;
            // 
            // btn_runMachine
            // 
            this.btn_runMachine.Location = new System.Drawing.Point(694, 9);
            this.btn_runMachine.Name = "btn_runMachine";
            this.btn_runMachine.Size = new System.Drawing.Size(161, 23);
            this.btn_runMachine.TabIndex = 7;
            this.btn_runMachine.Text = "Ejecutar";
            this.btn_runMachine.UseVisualStyleBackColor = true;
            // 
            // templateTuringMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 253);
            this.Controls.Add(this.btn_runMachine);
            this.Controls.Add(this.txt_instruction);
            this.Controls.Add(this.lbl_instruction);
            this.Controls.Add(this.lbl_stepsCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_actualState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "templateTuringMachine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.templateTuringMachine_FormClosed);
            this.Load += new System.EventHandler(this.templateTuringMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_actualState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stepsCounter;
        private System.Windows.Forms.Label lbl_instruction;
        private System.Windows.Forms.TextBox txt_instruction;
        private System.Windows.Forms.Button btn_runMachine;
    }
}