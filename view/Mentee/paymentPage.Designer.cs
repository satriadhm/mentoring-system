namespace mentoring_system.view.Mentee
{
    partial class PaymentPage
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
            cashRadioButton = new RadioButton();
            mobileBankingRadioButton = new RadioButton();
            ewalletRadioButton = new RadioButton();
            paymentMethodLabel = new Label();
            proceedButton = new Button();
            cancelPaymentButton = new Button();
            SuspendLayout();
            // 
            // cashRadioButton
            // 
            cashRadioButton.AutoSize = true;
            cashRadioButton.Location = new Point(369, 108);
            cashRadioButton.Name = "cashRadioButton";
            cashRadioButton.Size = new Size(59, 24);
            cashRadioButton.TabIndex = 26;
            cashRadioButton.TabStop = true;
            cashRadioButton.Text = "cash";
            cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // mobileBankingRadioButton
            // 
            mobileBankingRadioButton.AutoSize = true;
            mobileBankingRadioButton.Location = new Point(195, 108);
            mobileBankingRadioButton.Name = "mobileBankingRadioButton";
            mobileBankingRadioButton.Size = new Size(134, 24);
            mobileBankingRadioButton.TabIndex = 25;
            mobileBankingRadioButton.TabStop = true;
            mobileBankingRadioButton.Text = "Mobile Banking";
            mobileBankingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ewalletRadioButton
            // 
            ewalletRadioButton.AutoSize = true;
            ewalletRadioButton.Location = new Point(74, 108);
            ewalletRadioButton.Name = "ewalletRadioButton";
            ewalletRadioButton.Size = new Size(86, 24);
            ewalletRadioButton.TabIndex = 24;
            ewalletRadioButton.TabStop = true;
            ewalletRadioButton.Text = "E-Wallet";
            ewalletRadioButton.UseVisualStyleBackColor = true;
            // 
            // paymentMethodLabel
            // 
            paymentMethodLabel.AutoSize = true;
            paymentMethodLabel.BackColor = Color.Transparent;
            paymentMethodLabel.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            paymentMethodLabel.ForeColor = Color.SaddleBrown;
            paymentMethodLabel.Location = new Point(161, 34);
            paymentMethodLabel.Name = "paymentMethodLabel";
            paymentMethodLabel.Size = new Size(204, 31);
            paymentMethodLabel.TabIndex = 23;
            paymentMethodLabel.Text = "Payment Method";
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.NavajoWhite;
            proceedButton.FlatAppearance.BorderSize = 0;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            proceedButton.ForeColor = Color.SaddleBrown;
            proceedButton.Location = new Point(106, 164);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(132, 41);
            proceedButton.TabIndex = 22;
            proceedButton.Text = "Proceed";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += proceedButton_Click;
            // 
            // cancelPaymentButton
            // 
            cancelPaymentButton.BackColor = Color.LightCoral;
            cancelPaymentButton.FlatAppearance.BorderSize = 0;
            cancelPaymentButton.FlatStyle = FlatStyle.Flat;
            cancelPaymentButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancelPaymentButton.ForeColor = Color.Snow;
            cancelPaymentButton.Location = new Point(264, 164);
            cancelPaymentButton.Name = "cancelPaymentButton";
            cancelPaymentButton.Size = new Size(132, 41);
            cancelPaymentButton.TabIndex = 27;
            cancelPaymentButton.Text = "Cancel";
            cancelPaymentButton.UseVisualStyleBackColor = false;
            cancelPaymentButton.Click += cancelButton_Click;
            // 
            // PaymentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 239);
            Controls.Add(cancelPaymentButton);
            Controls.Add(cashRadioButton);
            Controls.Add(mobileBankingRadioButton);
            Controls.Add(ewalletRadioButton);
            Controls.Add(paymentMethodLabel);
            Controls.Add(proceedButton);
            MaximizeBox = false;
            Name = "PaymentPage";
            Text = "PaymentPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton cashRadioButton;
        private RadioButton mobileBankingRadioButton;
        private RadioButton ewalletRadioButton;
        private Label paymentMethodLabel;
        private Button proceedButton;
        private Button cancelPaymentButton;
    }
}