﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
using tekstil_profi_m.models;

namespace tekstil_profi_m.pages
{
    /// <summary>
    /// Логика взаимодействия для AddMerches.xaml
    /// </summary>
    public partial class AddMerches : Window
    {

        private Merch currentmerch = new Merch();
        public OpenFileDialog ofd = new OpenFileDialog();
        private string newsourthpath = string.Empty;
        private bool flag = false;


        public AddMerches(Merch sellectedmer)
        {
            InitializeComponent();
            if (sellectedmer != null)
            {
                currentmerch = sellectedmer;
            }
            DataContext = currentmerch;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (currentmerch.id == 0)
            {
                dipEntitie.GetContext().Merch.Add(currentmerch);
            }

            DbContextTransaction dbContextTransaction = null;

            try
            {
                if (currentmerch.id == 0)
                {
                    dipEntitie.GetContext().Merch.Add(currentmerch);
                }

                dbContextTransaction = dipEntitie.GetContext().Database.BeginTransaction();

                dipEntitie.GetContext().SaveChanges();

                MessageBox.Show("Информация сохранена!");
                dbContextTransaction.Commit();

            }
            catch (DbUpdateException ex)
            {
                if (dbContextTransaction != null)
                {
                    dbContextTransaction.Rollback();
                }

                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    MessageBox.Show($"Внутреннее исключение: {innerException.Message}");
                    innerException = innerException.InnerException;
                }

                MessageBox.Show("Ошибка при сохранении изменений. Дополнительные сведения в внутреннем исключении.");
            }
            catch (Exception ex)
            {
                if (dbContextTransaction != null)
                {
                    dbContextTransaction.Rollback();
                }

                MessageBox.Show($"Ошибка при обновлении записей. Дополнительные сведения: {ex.Message}");
            }
            finally
            {
                dbContextTransaction?.Dispose();
            }
        }

        private void Foto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedImagePath = openFileDialog.FileName;
                // Проверка на null перед установкой изображения
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    // Отображаем выбранное изображение в предварительном просмотре
                    PreviewImage.Source = new BitmapImage(new Uri(selectedImagePath));
                    PreviewImage.Visibility = Visibility.Visible; // Показываем изображение
                                                                  // Сохраняем абсолютный путь к выбранному изображению
                    currentmerch.photo = selectedImagePath;
                }
            }
        }

        private void nazClick(object sender, RoutedEventArgs e)
        {
            product prod = new product();
            Visibility = Visibility.Hidden;
            prod.Show();
        }

       

        
    }
}
