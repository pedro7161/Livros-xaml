   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   #      WpfApp2.MainWindow   6	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6&   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6h   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   'localclr-namespace:WpfApp2     6#    � Title$  
MainWindow��6X  $	��450��6k  $	��800��6x  .��5      �  � RowDefinitions 5   
   �� 5      $	��18* �6   �� 5      $
��401* �6   .+�5   
   ]� -   5        $
��menu��5      $��0��6    
�������.+�5      o� $	��Top=�6   .@�5	      m� $
��Sair��6   $	��120��6)   6:   m� 5
      $��Window��6   $	��120��6+   .@�5      m� $
��pag1��6   $	��120��6-    m� CommandParameter$ pagina1��6<    m� Command 6W   �� *
cmdnavegar+   ctrl �� Source# [  6�   m� 5      $
��pag2��6   $	��120��6-   $ pagina2��6<    6W   �� *
cmdnavegar+# [  6�   m� 5      $
��pag3��6   $	��120��6-   $ pagina3��6<    6W   �� *
cmdnavegar+# [  6�   5      5      5       � 5   
   -   5        $��myframe��5      $��1��6     � Source$) #/WpfApp2;component/views/Page1.xaml?�6,   6[   5      5      