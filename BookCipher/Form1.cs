﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            string encodedstring = Encrypt(plainText.Text);
            encodedText.Text = encodedstring;
        }

        private string Encrypt(string plainText)
        {
            string filepath = @"Z:\txt.txt";
            string textfile = File.ReadAllText(filepath);
            string[] wordArray = textfile.Split(',');
            string[] plainTextArray = plainText.Split(' ');
            string encodedText = "";
            for (int i = 0; i < plainTextArray.Length; i++)
            {
                string word = plainTextArray[i];
                int index = Array.IndexOf(wordArray, word);
                
                   if (index < 0)
                {

                    string message = "Një nga fjalet e shkruara nuk është në tekst file!";
                    string title = "Input Error!";
                    MessageBox.Show(message, title);

                }
            
                encodedText += index + 1;
                encodedText += " ";
            }

            return encodedText.TrimEnd();

        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
             string decodedtext = Decrypt(encodedText.Text);
            decodedText.Text = decodedtext;
        }

        
        static string Decrypt(string encodedText)
        {
           string filepath = @"Z:\txt.txt";
           string textfile = File.ReadAllText(filepath);
           
           int[] indexes = encodedText
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n) - 1)
                .ToArray();

            string plaintext = "";
            string[] wordArray = textfile.Split(',');
         
            foreach (int index in indexes)
            {
                plaintext += wordArray[index] + " ";
            }


            return plaintext.TrimEnd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
