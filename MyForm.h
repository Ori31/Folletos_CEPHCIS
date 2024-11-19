#pragma once
#include "MyForm1.h"

namespace $safeprojectname$ {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::TextBox^ txt_usuario;
	private: System::Windows::Forms::TextBox^ txt_contraseña;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ button2;


	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->txt_usuario = (gcnew System::Windows::Forms::TextBox());
			this->txt_contraseña = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(249, 245);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(285, 44);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Iniciar sesion como administrador";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// txt_usuario
			// 
			this->txt_usuario->Location = System::Drawing::Point(249, 93);
			this->txt_usuario->Name = L"txt_usuario";
			this->txt_usuario->Size = System::Drawing::Size(285, 22);
			this->txt_usuario->TabIndex = 1;
			this->txt_usuario->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox1_TextChanged);
			// 
			// txt_contraseña
			// 
			this->txt_contraseña->Location = System::Drawing::Point(249, 190);
			this->txt_contraseña->Name = L"txt_contraseña";
			this->txt_contraseña->Size = System::Drawing::Size(289, 22);
			this->txt_contraseña->TabIndex = 2;
			this->txt_contraseña->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox2_TextChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(320, 74);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(140, 16);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Usuario Administrador";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(351, 171);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(76, 16);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Contraseña";
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(249, 316);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(284, 41);
			this->button2->TabIndex = 5;
			this->button2->Text = L"Acceder como invitado";
			this->button2->UseVisualStyleBackColor = true;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(836, 420);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->txt_contraseña);
			this->Controls->Add(this->txt_usuario);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {

		String^ usuario = this->txt_usuario->Text;
		String^ contrasena = this->txt_contraseña->Text;

		if (usuario == "Administrador" && contrasena == "Admin123") {
			MessageBox::Show(L"Bienvenido " + txt_usuario->Text);
			CppWinFormsApp2::MyForm1^ Forms = gcnew CppWinFormsApp2::MyForm1();
			Forms->Show();
			this->Hide();

		}
		else {
			MessageBox::Show(L"El usuario o contraseña es incorrecto");
		}
		
	}
	private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void textBox2_TextChanged(System::Object^ sender, System::EventArgs^ e) {
	}
	};
}
