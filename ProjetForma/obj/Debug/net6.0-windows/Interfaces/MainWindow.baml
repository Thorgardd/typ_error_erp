   M S B A M L   `   `   `  ����F  BProjetForma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ProjetFormaProjetForma  5   	       ProjetForma.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   +localclr-namespace:ProjetForma     5   	     � Title$  TYP_ADMIN (Version 0.1)��5   	   
������  � WindowStyle$
 None=�5
   	    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $
��1500��5   	   $	��960��5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��4* �6    �� 5      $��7* �6    �� 5      $��4* �6     � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $
��2.5* �6#   .+�5"      ��  �� CornerRadius$ 10��6   $��3��6'   $��2��68   ��5#      �� 5$      .��5%      � 	 � Color$	 #264653��6'   
 � Offset$	
 1.0Q�67   � 5&      $	 #E76F51��6'   $	
 0.0Q�67   5'      5)      �� 5+      $��3��6   $��1��6*   $��0��6>   $��0��6K   .+�5,      �� $��/Images/Logo.png��6   $	��275��5-      $��	0,125,0,0q�5.      �� 50      -   5         ��Name$ 
ButtonUser��54      $��Utilisateurs��50      $	��150��51      $��50��52      $��22(�53      $��	0,100,0,0q�55      57      �� 59      -   5        $ ButtonModerate��5=      $��
Moderation��59      $	��150��5:      $��50��5;      $��22(�5<      $��0,50,0,0q�5>      5@      �� 5B      -   5        $ ButtonCanal��5F      $��Canaux��5B      $	��150��5C      $��50��5D      $��22(�5E      $��0,50,0,0q�5G      5I      �� 5K      -   5        $
 Quit��5O      $��Quitter��5K      $	��150��5L      $��50��5M      $��22(�5N      $��	0,125,0,0q�5P      5S      5U      �� 5W      $��3��6   
���   � J� Opacity$	 0.6Q�5Y      $��1��5Z      $��Center=�5[      $��Center=�5\      $	��800��5]      $	��734��5^      5`      5c      5d      5e      