#pragma once

namespace CppWinFormsApp2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de MyForm3
	/// </summary>
	public ref class MyForm3 : public System::Windows::Forms::Form
	{
	public:
		MyForm3(void)
		{
			InitializeComponent();
			//
			//TODO: agregar código de constructor aquí
			//
		}

	protected:
		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		~MyForm3()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ textBox1;

		   // ANIMACIÓN DE LA BARRA DE CARGA -MAU
	private: System::Void Button3_Click(System::Object^ sender, System::EventArgs^ e) {
		
		this->progressBar1->Value = 0;

		for (int i = 0; i <= 100; i++) {
			this->progressBar1->Value = i;
			System::Windows::Forms::Application::DoEvents();
			for (int j = 0; j < 1000000; j++);
		}

	}
		   //ANIMACIÓN TERMINA AQUÍ -MAU

	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Panel^ panel1;
	private: System::Windows::Forms::VScrollBar^ vScrollBar1;
	private: System::Windows::Forms::Timer^ timer1;
	private: System::Windows::Forms::ProgressBar^ progressBar1;

	private: System::ComponentModel::IContainer^ components;

	protected:

	private:
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm3::typeid));
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->vScrollBar1 = (gcnew System::Windows::Forms::VScrollBar());
			this->progressBar1 = (gcnew System::Windows::Forms::ProgressBar());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->label2 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->panel1->SuspendLayout();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(148, 428);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(177, 54);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Regresar";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm3::button1_Click);
			// 
			// label1
			// 
			this->label1->Font = (gcnew System::Drawing::Font(L"Bahnschrift SemiCondensed", 7.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(71, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(175, 55);
			this->label1->TabIndex = 1;
			this->label1->Text = L"UNIVERSIDAD AUTONOMA NACIONAL DE MEXICO";
			this->label1->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->Location = System::Drawing::Point(-2, 2);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(83, 81);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 2;
			this->pictureBox1->TabStop = false;
			this->pictureBox1->Click += gcnew System::EventHandler(this, &MyForm3::pictureBox1_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(148, 86);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(573, 22);
			this->textBox1->TabIndex = 3;
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &MyForm3::textBox1_TextChanged);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(626, 424);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(177, 54);
			this->button2->TabIndex = 5;
			this->button2->Text = L"Seleccionar Folleto";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm3::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(727, 81);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(76, 33);
			this->button3->TabIndex = 6;
			this->button3->Text = L"Buscar";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm3::Button3_Click);
			// 
			// panel1
			// 
			this->panel1->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->panel1->BorderStyle = System::Windows::Forms::BorderStyle::Fixed3D;
			this->panel1->Controls->Add(this->vScrollBar1);
			this->panel1->Location = System::Drawing::Point(148, 115);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(655, 267);
			this->panel1->TabIndex = 7;
			this->panel1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &MyForm3::panel1_Paint);
			// 
			// vScrollBar1
			// 
			this->vScrollBar1->Dock = System::Windows::Forms::DockStyle::Right;
			this->vScrollBar1->Location = System::Drawing::Point(626, 0);
			this->vScrollBar1->Name = L"vScrollBar1";
			this->vScrollBar1->Size = System::Drawing::Size(25, 263);
			this->vScrollBar1->TabIndex = 0;
			this->vScrollBar1->Scroll += gcnew System::Windows::Forms::ScrollEventHandler(this, &MyForm3::vScrollBar1_Scroll);
			// 
			// progressBar1
			// 
			this->progressBar1->Location = System::Drawing::Point(148, 389);
			this->progressBar1->Name = L"progressBar1";
			this->progressBar1->Size = System::Drawing::Size(653, 23);
			this->progressBar1->TabIndex = 8;
			// 
			// timer1
			// 
			this->timer1->Interval = 10;
			this->timer1->Tick += gcnew System::EventHandler(this, &MyForm3::timer1_Tick);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(317, 32);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(272, 32);
			this->label2->TabIndex = 9;
			this->label2->Text = L"Buscador de folletos";
			// 
			// MyForm3
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(946, 494);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->progressBar1);
			this->Controls->Add(this->panel1);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm3";
			this->Text = L"MyForm3";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->panel1->ResumeLayout(false);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
	}

private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}

private: System::Void vScrollBar1_Scroll(System::Object^ sender, System::Windows::Forms::ScrollEventArgs^ e) {
}
private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void pictureBox1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void panel1_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
}
};
}
