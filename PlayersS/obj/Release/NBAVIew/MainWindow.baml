   M S B A M L   `   `   `  ���� C  ?PlayersS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PlayersSPlayersS      PlayersS.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:PlayersS       � Title$  Players��$	��450��$	��800��$��Center=�$��Center=�.��� .+��  � ColumnDefinitions �� $��1* ��� $��2* ��� $��2* � � RowDefinitions �� $��30 ��� �� �� �� .+�� $��3��.+�o� .@�m� $
��File��$��16(�.@�m� -   $��Zapisz��$��16(�m� -   $��Wczytaj��$��16(�� $��1��$��4��$��1��$��4��.+�&   System.Windows.Controls.DataGrid  -     Name$ Tabela��   
IsReadOnly .  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%~   '        �� "  .���  � ��
 ���@���  � ��$ SemiBold"���  � ��$ 0,0,1,2q���  � ��
 �   �	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+  $
 Nazwisko��$ 3*  �� *	firstname+  $
 Imię��$ 3*  �� *
lastname+  $	
 nba��$ 2*  �� *nba+  $
 
Wzrost (m)��$ 2*  �� *height+  $
 	Waga (kg)��$ 2*  �� *weight+  $
 College��$ 2*  �� *	college+  $
 Pochodzenie��$ 2*  �� *affiliation+� $��1��$��4��.+��  �� �� �� �� .+��  �� �� �� .+��� $��Wprowadź nazwisko ��$��16(�$��Center=�$��Center=��� -    ��Name$ WprowadzanieImienia��$��1��$��5,0,5,0q�$��Center=� �� TextWrapping$
 Wrap=��� -    ��Name$ SzukajZ��$��2��$��Szukaj Zawodnika��$��16(�� $��1�� �� �� �� .+��� $��Wprowadź kraj ��$��16(�$��Center=�$��Center=��� -   $ WprowadzenieKraju��$��1��$��5,0,5,0q�$��Center=�$
 Wrap=��� -   $ SzukajK��$��2��$��Szukaj kraju��$��16(�� $��2�� �� �� .+��� -   $ 
PodajIlosc��$
��0,10q�$��Ilość��$��12(��� -	    ��Name$ IloscZawodnikow��$��1��$��10,10q�$��Center=�$��Center=�$��20(��� -
   $
 Exit��$��3��$��0,10,0,0q�$��Wyjście��$��16(�