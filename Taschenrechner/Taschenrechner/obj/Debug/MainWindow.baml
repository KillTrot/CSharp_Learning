   M S B A M L   `   `   `  ����I  ETaschenrechner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaschenrechnerTaschenrechner  5   	   I)clr-namespace:Taschenrechner.UserControlsTaschenrechner.UserControls  5   	       Taschenrechner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Taschenrechner     5   	   BUserControls)clr-namespace:Taschenrechner.UserControls     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��300��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5      $	��25* �6    � RowDefinitions 5   
   �� 5      $��16.66* �6   �� 5      $��16.66* �6   �� 5      $��16.66* �6   �� 5      $��16.66* �6   �� 5      $��16.66* �6   �� 5      $��16.66* �6   .+�5   
   ,   &Taschenrechner.UserControls.ResultView  -   5          Name$ 
resultView��5   "   
��� � �$��1q�6J   $��0��6^   $��4��6k   6�   �� 5   
   -   5        $��1��5      $��0��6   $	��√��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   
 � Tag$ 
squareRoot��6h   6y   �� 5   
   -   5        $��1��5      $��1��6   $��^2��6.   $��5q�6;   $
��Bold"�6F   $��20 px(�6X   $	 pow��6i   6s   �� 5   
   -   5        $��1��5      $��2��6   $	��+/-��6.   $��5q�6<   $
��Bold"�6G   $��20 px(�6Y   $ negation��6j   6y   �� 5   
   -   5        $��1��5      $��3��6   
��� E��$��CE��6E   $��5q�6R   $
��Bold"�6]   $ clearAll��6o   $��20 px(�6~   6�   �� 5   
   -   5        $��2��5      $��0��6   $��7��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5   
   -   5        $��2��5      $��1��6   $��8��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5    
   -   5        $��2��5       $��2��6   $��9��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5!   
   -	   5        $��2��5!      $��3��6   $��÷��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $ division��6h   6w   �� 5"   
   -
   5        $��3��5"      $��0��6   $��4��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5#   
   -   5        $��3��5#      $��1��6   $��5��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5$   
   -   5        $��3��5$      $��2��6   $��6��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5%   
   -   5        $��3��5%      $��3��6   $��×��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $ multiplication��6h   6}   �� 5&   
   -   5        $��4��5&      $��0��6   $��1��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5'   
   -   5        $��4��5'      $��1��6   $��2��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5(   
   -   5        $��4��5(      $��2��6   $��3��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5)   
   -   5        $��4��5)      $��3��6   $��-��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $ minus��6h   6t   �� 5*   
   -   5        $��5��5*      $��0��6   $��0��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   6h   �� 5+   
   -   5        $��5��5+      $��1��6   $��.��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $ point��6h   6t   �� 5,   
   -   5        $��5��5,      $��2��6   $��=��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $ equals��6h   6u   �� 5-   
   -   5        $��5��5-      $��3��6   $��+��6.   $��5q�6:   $
��Bold"�6E   $��20 px(�6W   $
 plus��6h   6s   5.      5/      