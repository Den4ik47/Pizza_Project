   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Stolik   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � WindowStyle$  
ToolWindow=�5   	    � Title$ Stolik��5	   	   $	��380��6   $	��800��6%   .��5
      � $��0,0,0,-2q�6    � RowDefinitions 5   
   �� 5      $
��161* �6   �� 5      $
��190* �6    � ColumnDefinitions 5   
   �� 5      $	��44* �6   �� 5      $	��45* �6   �� 5      $	��43* �6   .+�5   
   �� -   5         ��Name$ Pizza��5      $��Pizza��6    $
��Left=�60   $	��Top=�6K   $	��265��6c   $	��159��6o   $��2��6|   $��0,1,0,0q�6�   6�   �� 5   
   -   5        $ Napoje��5      $��Napoje��6!   $
��Left=�62   $	��Top=�6M   $	��268��6e   $	��159��6q    J� RenderTransformOrigin$ 0.5,0.5&�6~   $��2,0,0,0q�6�   $��1��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.051Q�6&   T� 5      5      5      �� 5   
   -   5        $ 
Przystawki��5      $��
Przystawki��6%   $
��Left=�6:   $	��Top=�6U   $	��261��6m   $	��159��6y   $ 0.5,0.5&�6�   $��0,1,-3,0q�6�   $��2��6�   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$      $ -0.051Q�6&   T� 5%      5&      5(      �� 5)   
   -   5        $ Glowne_Menu��5)      $��Glowne Menu��6&   $
��Left=�6<   $	��Top=�6W   $	��264��6o   $	��189��6{   $��1��6�   �� 5*   
   -   5        $ Gotowe��5*      $��Rozliczycz sie��6!   $
��Left=�6:   $	��Top=�6U   $	��275��6m   $	��191��6y   $��1��6�   $��2��6�   $��1��6�   $��0,0,0,-1q�6�   �� 5+   
   -   5        $
 Stat��5+      $��	Dokladnie��6   $
��Left=�63   $	��Top=�6N   $	��258��6f   $	��190��6r   $��2��6   $��1��6�   5-      5.      