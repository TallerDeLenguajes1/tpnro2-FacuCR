   M S B A M L   `   `   `  ����E  AAplicacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Aplicacion.VistasAplicacion.Vistas  5   	   %    Aplicacion.Vistas.ABMCrearCurso   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Aplicacion.Vistas     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ABMCrearCurso��5	   	   $	��519��6   $	��749��6,   .��5
      � .+�5   
   �� -   5         ��Name$ tblCrearCurso��5       �� TextAlignment$ Center=�5      ���#673ab7
������� #  MaterialDesignDisplay3TextBlock#��[  5      $��	0,0,0,408q�6F   �� 6Z   $�Crear Curso��6^   5      �� 5   
   -   5         ��Name$ txtTema��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tema del curso��6#    % !MaterialDesignFloatingHintTextBox#��[ 6S   $��47,126,528,320q�6�   6�   �� 5   
   -   5        $��cbxTurno��5      $ Turno��6#    & "MaterialDesignFloatingHintComboBox#��[ 6J   $��47,235,528,211q�6�   $��42��6�   .@�5      �� .��6   	Mañana5      �� 5      .��6   Tarde5      �� 5      .��6   Noche5      5      �� 5   
   -   5         ��Name$ cbxModalidad��5      $ 	Modalidad��6)   #��[ 6T   $��47,357,528,89q�6�   $��42��6�   .@�5      �� $��
Presencial��6   �� 5       $��Semi Presencial��6   �� 5!      $��No Presencial��6   5"      �� 5#   
   -   5        $��sldInscripcion��5#       � Minimum$ 0Q�6'    � Maximum$ 10000Q�63      MaterialDesignDiscreteSlider#��[ 6C    � ToolTip$" MaterialDesignDiscreteSlider��6y   	 � Value$
	 5000Q�6�   $	��280��6�   $��392,98,69,327q�6�   �� 5$   
   -   5        $��lblInscipcion��5$      $��Inscripción��6%   $
��Left=�6;   $��Center=�6V   $��45��6x   $��324,123,0,0q�6�   $	��Top=�6�   $��68��6�   �� 5%   
   -   5        
 ��Name$
 sldCuota��5%      $ 0Q�6#   $ 10000Q�6/   #��[ 6?   $" MaterialDesignDiscreteSlider��6u   $
	 5000Q�6�   $	��280��6�   $��392,213,69,210q�6�   �� 5&   
   -   5         ��Name$ lblCuota��5&      $��Cuota��6"   $
��Left=�62   $��Center=�6M   $��45��6o   $��342,238,0,0q�6{   $	��Top=�6�   $��50��6�   �� 5'   
   -	   5         ��Name$ btnCrear��5'       ! MaterialDesignFlatMidBgButton#��[ 6#   $! MaterialDesignFlatMidButton��6Z   $��552,357,69,89q�6�   $��CREAR��6�   $
��Auto��6�   6�   �� 5(   
   -
   5        $��btnCancelar��5(        MaterialDesignFlatButton#��[ 6$   $ MaterialDesignFlatButton��6V   $��392,357,229,89q�6y   $��CANCELAR��6�   $
��Auto��6�   6�   5)      5*      