namespace calculadorasimple
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            valorA = new Label();
            text1 = new TextBox();
            valorB = new Label();
            resultado = new Label();
            text2 = new TextBox();
            textresultado = new TextBox();
            label4 = new Label();
            suma = new Button();
            resta = new Button();
            division = new Button();
            valorC = new Label();
            toolTip1 = new ToolTip(components);
            text3 = new TextBox();
            SuspendLayout();
            // 
            // valorA
            // 
            valorA.AutoSize = true;
            valorA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            valorA.Location = new Point(67, 48);
            valorA.Name = "valorA";
            valorA.Size = new Size(68, 21);
            valorA.TabIndex = 0;
            valorA.Text = "valor A:";
            // 
            // text1
            // 
            text1.Location = new Point(132, 50);
            text1.Name = "text1";
            text1.Size = new Size(110, 23);
            text1.TabIndex = 1;
            text1.Text = "45";
            // 
            // valorB
            // 
            valorB.AutoSize = true;
            valorB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            valorB.Location = new Point(307, 50);
            valorB.Name = "valorB";
            valorB.Size = new Size(67, 21);
            valorB.TabIndex = 2;
            valorB.Text = "valor B:";
            //
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.BackColor = SystemColors.ActiveCaption;
            resultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.Location = new Point(129, 305);
            resultado.Name = "resultado";
            resultado.Size = new Size(93, 21);
            resultado.TabIndex = 3;
            resultado.Text = "resultados:";
            // 
            // text2
            // 
            text2.Location = new Point(380, 50);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 4;
            // 
            // textresultado
            // 
            textresultado.Location = new Point(228, 303);
            textresultado.Name = "textresultado";
            textresultado.Size = new Size(270, 23);
            textresultado.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 361);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 7;
            // 
            // suma
            // 
            suma.Location = new Point(100, 138);
            suma.Name = "suma";
            suma.Size = new Size(161, 23);
            suma.TabIndex = 8;
            suma.Text = "suma";
            suma.UseVisualStyleBackColor = true;
            suma.Click += suma_Click;
            // 
            // resta
            // 
            resta.Location = new Point(346, 138);
            resta.Name = "resta";
            resta.Size = new Size(162, 23);
            resta.TabIndex = 9;
            resta.Text = "resta";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // division
            // 
            division.Location = new Point(572, 138);
            division.Name = "division";
            division.Size = new Size(116, 23);
            division.TabIndex = 10;
            division.Text = "division";
            division.UseVisualStyleBackColor = true;
            // 
            // valorC
            // 
            valorC.AutoSize = true;
            valorC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            valorC.Location = new Point(533, 54);
            valorC.Name = "valorC";
            valorC.Size = new Size(61, 20);
            valorC.TabIndex = 11;
            valorC.Text = "valor C:";
          
            // 
            // text3
            // 
            text3.Location = new Point(600, 52);
            text3.Name = "text3";
            text3.Size = new Size(100, 23);
            text3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(808, 450);
            Controls.Add(text3);
            Controls.Add(valorC);
            Controls.Add(division);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(label4);
            Controls.Add(textresultado);
            Controls.Add(text2);
            Controls.Add(resultado);
            Controls.Add(valorB);
            Controls.Add(text1);
            Controls.Add(valorA);
            Name = "Form1";
            Text = "calculadora simple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label valorA;
        private TextBox text1;
        private Label valorB;
        private Label resultado;
        private TextBox text2;
        private TextBox textresultado;
        private Label label4;
        private Button suma;
        private Button resta;
        private Button division;
        private Label valorC;
        private ToolTip toolTip1;
        private TextBox text3;
    }
}