using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using tekstil_profi_m.classes;
using tekstil_profi_m.models;
using static tekstil_profi_m.pages.nackladn;

namespace tekstil_profi_m.pages
{
    /// <summary>
    /// Логика взаимодействия для pechNacladn.xaml
    /// </summary>
    public partial class pechNacladn : Window
    {
        private ObservableCollection<nackladn.OrderItem> orderItems;
        




        public pechNacladn(ObservableCollection<nackladn.OrderItem> orderItems)
        {
            InitializeComponent();
            foreach (var orderItem in orderItems)
            {
                orderItem.OtvetCollection = new ObservableCollection<Otvetstvenie>(dboconnect.modeldb.Otvetstvenie);
            }
            this.orderItems = orderItems;
            OrderLV.ItemsSource = orderItems;

        }




        
        private void ydalClick(object sender, RoutedEventArgs e)
        {
            if (OrderLV.SelectedItem != null)
            {
                OrderItem selectedOrderItem = OrderLV.SelectedItem as OrderItem;
                if (selectedOrderItem != null)
                {
                    orderItems.Remove(selectedOrderItem);
                    
                }
            }
        }

        

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)this.ActualWidth, (int)this.ActualHeight, 96, 96, PixelFormats.Pbgra32);
    renderTargetBitmap.Render(this);

    // Создаем Image, чтобы отобразить RenderTargetBitmap
    Image image = new Image();
    image.Source = renderTargetBitmap;

    // Создаем PrintDialog для печати
    PrintDialog printDialog = new PrintDialog();

    if (printDialog.ShowDialog() == true)
    {
        // Устанавливаем ориентацию печати на горизонтальную
        printDialog.PrintTicket.PageOrientation = System.Printing.PageOrientation.Landscape;

        // Печать изображения
        printDialog.PrintVisual(image, "Print Page");

        // Если вы также хотите сохранить изображение, то можно использовать следующий код:
        // SaveImage(renderTargetBitmap);
    }



        }
        public void SavePlanClone()
        {
            try
            {
                using (var context = new dipEntitie())
                {
                    foreach (var orderItem in orderItems)
                    {
                        var order = new Plan
                        {
                            id_merch = orderItem.MerchId,
                            id_otvetst = orderItem.OtvetPoint?.id ?? 1,
                            material = orderItem.MerchMaterial,
                            name = orderItem.MerchName,
                            razmer = orderItem.MerchRazmer,
                            color = orderItem.MerchColor,
                            photo = orderItem.PhotoPath,
                        };

                        context.Plan.Add(order);

                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении заказа в базу данных: {ex.Message}", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void SavePlan(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new dipEntitie())
                {
                    foreach (var orderItem in orderItems)
                    {
                        var order = new Plan
                        {





                            id_merch = orderItem.MerchId,
                            id_otvetst = orderItem.OtvetPoint?.id ?? 1,
                            material = orderItem.MerchMaterial,
                            name = orderItem.MerchName,
                            razmer = orderItem.MerchRazmer,
                            color = orderItem.MerchColor,
                            photo = orderItem.PhotoPath,
                            count = orderItem.count // Сохранение количества товара




                        };

                        context.Plan.Add(order);

                        

                        
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении заказа в базу данных: {ex.Message}", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
