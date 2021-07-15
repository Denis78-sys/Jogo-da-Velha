using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    
    public partial class Form2 : Form
    {
        int faltam_jogadores=9, ponto_jogaodor1, pontos_jogador2, n_vez = 1, vencedor1=0, vencedor2=0, contagem1 = 0, contagem2 = 0, bot_ok = 0, empate = 0;
        char nome_jogaor1;
        char nome_jogador2;
        char vez_jogador;
        
        
        public Form2(string nome1, string nome2)
        {
            InitializeComponent();
            label_nome_jogador_1.Text = nome1;
            label_nome_jogador_2.Text = nome2;
            label1_nome_jogador_vez.Text = nome1 + ", você começa!";
            
            
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if(btn_8.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_8.Text = "X";
                    btn_8.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_8.Text = "O";
                        btn_8.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
               
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                        
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                            
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                    
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                        
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                 
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                     
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                    
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                           
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                         
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                             
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                                      
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if(btn_9.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_9.Text = "X";
                    btn_9.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_9.Text = "O";
                        btn_9.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Condição vencedor//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
              
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
         
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
              
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
           
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                           
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                        
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                           
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
             
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                   
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                          
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                           
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                      
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                           
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //


        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if(btn_4.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_4.Text = "X";
                    btn_4.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_4.Text = "O";
                        btn_4.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
               
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                    
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
        
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                        
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                    
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                         
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                             ;
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                 
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
       
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                     
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
              
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                          
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                             
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if(btn_5.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_5.Text = "X";
                    btn_5.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_5.Text = "O";
                        btn_5.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada iválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                     
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                           
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                          
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                        
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                   
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                         
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
               
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                 
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                    
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                   
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                     
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                        
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                      
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                             
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if(btn_6.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_6.Text = "X";
                    btn_6.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_6.Text = "O";
                        btn_6.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jodgada iválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
       
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
           
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
            
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
  
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
             
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
   
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
       
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
     
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";

                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
        
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                   
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                        
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            n_vez = 1;
            btn_1.Text = "";
            btn_2.Text = "";
            btn_3.Text = "";
            btn_4.Text = "";
            btn_5.Text = "";
            btn_6.Text = "";
            btn_7.Text = "";
            btn_8.Text = "";
            btn_9.Text = "";

            faltam_jogadores = 9;
            label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (btn_1.Text == "")
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_1.Text = "X";
                    btn_1.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_1.Text = "O";
                        btn_1.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
         
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
    
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
          
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
              
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                       
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                         
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
  
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
       
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
             
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                 
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                 
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                         
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                            
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //


        }

        private void label_fim_de_jogo_Click(object sender, EventArgs e)
        {

        }

        private void n_pontos_jogador1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (faltam_jogadores == 0)
            {
                bot_ok = 1;
            }

            if(vencedor1 != 0 || vencedor2 != 0 || bot_ok != 0)
            {

                bot_ok = 0;
                faltam_jogadores = 0;
                n_vez = 1;
                btn_1.Text = "";
                btn_2.Text = "";
                btn_3.Text = "";
                btn_4.Text = "";
                btn_5.Text = "";
                btn_6.Text = "";
                btn_7.Text = "";
                btn_8.Text = "";
                btn_9.Text = "";
              
                faltam_jogadores = 9;

                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
              
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + ", você começa!";
                label1_nome_jogador_vez.ForeColor = Color.Blue;

                if (vencedor1 != 0)
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + ", você começa!";
                    n_vez = 1;
                }
                else
                {
                    if (vencedor2 != 0)
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + ", você começa!";
                        n_vez = 2;
                    }
                }

                if (vencedor1 != 0)
                {
                    contagem1 = contagem1 + 1;

                }
                else
                {
                    if (vencedor2 != 0)
                    {
                        contagem2 = contagem2 + 1;
                    }
                    else
                    {
                        if (vencedor1 == 0 && vencedor2 == 0)
                        {
                            empate = empate + 1;
                        }
                    }
                }


                n_pontos_jogador1.Text = Convert.ToString(contagem1);
                n_pontos_jogador2.Text = Convert.ToString(contagem2);
                label_empate.Text = Convert.ToString(empate);
                vencedor1 = 0;
                vencedor2 = 0;
            }
            else
            {
                MessageBox.Show("O jogo ainda não acabou!");
            }
            


        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if(btn_2.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_2.Text = "X";
                    btn_2.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_2.Text = "O";
                        btn_2.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
          
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
            
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
        
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                  
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                     
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                               
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                           
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
              
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                  
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                    
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                           
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                     
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                        
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if(btn_3.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_3.Text = "X";
                    btn_3.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_3.Text = "O";
                        btn_3.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }

                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
            }
            else
            {
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Vencedor1//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
       
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
          
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
           
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
            
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
         
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
               
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                             
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
   
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
          
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                   
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
            
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                       
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                          
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                            
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if(btn_7.Text == "" && vencedor1 == 0 && vencedor2 == 0)
            {
                if (n_vez == 1 || n_vez == 3 || n_vez == 5 || n_vez == 7 || n_vez == 9)
                {
                    btn_7.Text = "X";
                    btn_7.ForeColor = Color.Red;
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " sua vez de jogar!";
                }
                else
                {
                    if (n_vez == 2 || n_vez == 4 || n_vez == 6 || n_vez == 8 || n_vez == 10)
                    {
                        btn_7.Text = "O";
                        btn_7.ForeColor = Color.Blue;
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " sua vez de jogar!";
                    }
                }
                
                n_vez = n_vez + 1;
                faltam_jogadores = faltam_jogadores - 1;
                label2_n_jogadas_fim.Text = Convert.ToString(faltam_jogadores);
               

            }
            else
            {
                
                MessageBox.Show("Jogada inválida");
                vencedor1 = vencedor1 - 1;
                vencedor2 = vencedor2 - 1;
            }
            //Validadar vencedor//
            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
             
                vencedor1 = vencedor1 + 1;
                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if(btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                   
                    vencedor1 = vencedor1 + 1;
                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else 
                {
                    if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                        
                        vencedor1 = vencedor1 + 1;
                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "X" && btn_4.Text == "X" && btn_1.Text == "X")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                           
                            vencedor1 = vencedor1 + 1;
                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "X" && btn_5.Text == "X" && btn_2.Text == "X")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                               
                                vencedor1 = vencedor1 + 1;
                                n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "X" && btn_6.Text == "X" && btn_3.Text == "X")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                 
                                    vencedor1 = vencedor1 + 1;
                                    n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "X" && btn_5.Text == "X" && btn_3.Text == "X")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                        
                                        vencedor1 = vencedor1 + 1;
                                        n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_1.Text + " venceu!!!";
                                            
                                            vencedor1 = vencedor1 + 1;
                                            n_pontos_jogador1.Text = Convert.ToString(vencedor1);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Fim condição vencedor1//
            // Condição vencedor2//
            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
               
                vencedor2 = vencedor2 + 1;
                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                label1_nome_jogador_vez.ForeColor = Color.Green;
            }
            else
            {
                if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
                {
                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                    
                    vencedor2 = vencedor2 + 1;
                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                    label1_nome_jogador_vez.ForeColor = Color.Green;
                }
                else
                {
                    if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
                    {
                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                       
                        vencedor2 = vencedor2 + 1;
                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                        label1_nome_jogador_vez.ForeColor = Color.Green;
                    }
                    else
                    {
                        if (btn_7.Text == "O" && btn_4.Text == "O" && btn_1.Text == "O")
                        {
                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                           
                            vencedor2 = vencedor2 + 1;
                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                            label1_nome_jogador_vez.ForeColor = Color.Green;
                        }
                        else
                        {
                            if (btn_8.Text == "O" && btn_5.Text == "O" && btn_2.Text == "O")
                            {
                                label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                               
                                vencedor2 = vencedor2 + 1;
                                n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                label1_nome_jogador_vez.ForeColor = Color.Green;
                            }
                            else
                            {
                                if (btn_9.Text == "O" && btn_6.Text == "O" && btn_3.Text == "O")
                                {
                                    label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                                   
                                    vencedor2 = vencedor2 + 1;
                                    n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                    label1_nome_jogador_vez.ForeColor = Color.Green;
                                }
                                else
                                {
                                    if (btn_7.Text == "O" && btn_5.Text == "O" && btn_3.Text == "O")
                                    {
                                        label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                                       
                                        vencedor2 = vencedor2 + 1;
                                        n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                        label1_nome_jogador_vez.ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
                                        {
                                            label1_nome_jogador_vez.Text = label_nome_jogador_2.Text + " venceu!!!";
                                           
                                            vencedor2 = vencedor2 + 1;
                                            n_pontos_jogador2.Text = Convert.ToString(vencedor2);
                                            label1_nome_jogador_vez.ForeColor = Color.Green;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Fim condição vencedor 2 //

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
