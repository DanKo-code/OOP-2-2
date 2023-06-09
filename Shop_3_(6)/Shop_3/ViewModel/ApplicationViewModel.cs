﻿using Microsoft.Win32;
using Shop_3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using Shop_3.UndoRedo;

namespace Shop_3.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        Product selectedProduct;

        IFileService fileService;
        IDialogService dialogService;

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        public NHist histForBack = new NHist();
        public NHist histForForward = new NHist();
        public Saf SaveData()
        {
            return new Saf(ref products);
        }
        public void RestoreDataBack(Saf data)
        {
            histForForward.Form.Push(SaveData());
            Products = data.list;
        }
        public void RestoreDataForward(Saf data)
        {
            histForBack.Form.Push(SaveData());
            Products = data.list;
        }
        private RelayCommand undo;
        private RelayCommand redo;
        public RelayCommand Undo
        {
            get
            {
                return undo ??
                  (undo = new RelayCommand(obj =>
                  {
                      if (histForBack.Form.Count > 0)
                      {
                          RestoreDataBack(histForBack.Form.Pop());
                      }
                      else
                      {
                          MessageBox.Show("Стек пуст,назад нельзя");
                      }
                      OnPropertyChanged("Products");
                  }));
            }
        }
        public RelayCommand Redo
        {
            get
            {
                return redo ??
                  (redo = new RelayCommand(obj =>
                  {
                      if (histForForward.Form.Count > 0)
                      {
                          RestoreDataForward(histForForward.Form.Pop());
                      }
                      else
                      {
                          MessageBox.Show("Стек пуст,вперёд нельзя");
                      }
                      OnPropertyChanged("Products");
                  }));
            }
        }

        //смена языка
        //Англ
        private RelayCommand changeToEng;
        public RelayCommand ChangeToEng
        {
            get
            {
                return changeToEng ??
                  (changeToEng = new RelayCommand(obj =>
                  {
                      try
                      {
                          Application.Current.Resources.MergedDictionaries[0].Source = 
                          new Uri("./Resources/Eng.xaml", UriKind.RelativeOrAbsolute);
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }


        //Рус
        private RelayCommand changeToRus;
        public RelayCommand ChangeToRus
        {
            get
            {
                return changeToRus ??
                  (changeToRus = new RelayCommand(obj =>
                  {
                      try
                      {
                          Application.Current.Resources.MergedDictionaries[0].Source =
                          new Uri("./Resources/Rus.xaml", UriKind.RelativeOrAbsolute);
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }


        // команда добавления фотографии
        private RelayCommand addImage;
        public RelayCommand AddImage
        {
            get
            {
                return addImage ??
                  (addImage = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              Product product = obj as Product;
                              if (product != null)
                              {
                                  Products[Products.IndexOf(product)].Image = new BitmapImage(new Uri(dialogService.FilePath, UriKind.Absolute));
                              }
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }

        // команда поиска
        private RelayCommand search;
        public RelayCommand Search
        {
            get
            {
                return priceSort ??
                  (priceSort = new RelayCommand(obj =>
                  {
                      try
                      {
                          var temp = Products.Where(x=>x.ShortTitle == obj.ToString());


                          //var temp = Products.OrderBy(x => x.Price).ToList();

                          Products.Clear();

                          foreach (var product in temp)
                          {
                              Products.Add(product);
                          }


                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }

        // команды фильтрации
        //Цена
        private RelayCommand priceSort;
        public RelayCommand PriceSort
        {
            get
            {
                return priceSort ??
                  (priceSort = new RelayCommand(obj =>
                  {
                      try
                      {


                          var temp = Products.OrderBy(x => x.Price).ToList();

                          Products.Clear();

                          foreach (var product in temp)
                          {
                              Products.Add(product);
                          }

                          
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }

        //Рейтинг
        private RelayCommand ratingSort;
        public RelayCommand RatingSort
        {
            get
            {
                return ratingSort ??
                  (ratingSort = new RelayCommand(obj =>
                  {
                      try
                      {
                          var temp = Products.OrderBy(x => x.Rating).ToList();

                          Products.Clear();

                          foreach (var product in temp)
                          {
                              Products.Add(product);
                          }


                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }

        //Количество
        private RelayCommand amountSort;
        public RelayCommand AmountSort
        {
            get
            {
                return amountSort ??
                  (amountSort = new RelayCommand(obj =>
                  {
                      try
                      {
                          var temp = Products.OrderBy(x => x.Amount).ToList();

                          Products.Clear();

                          foreach (var product in temp)
                          {
                              Products.Add(product);
                          }


                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }

                  }));
            }
        }

        // команда сохранения файла
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.SaveFileDialog() == true)
                          {
                              fileService.Save(dialogService.FilePath, Products.ToList());
                              dialogService.ShowMessage("Файл сохранен");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        // команда открытия файла
        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              var phones = fileService.Open(dialogService.FilePath);
                              Products.Clear();
                              foreach (var p in phones)
                                  Products.Add(p);
                              dialogService.ShowMessage("Файл открыт");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Product product = new Product();
                      histForBack.Form.Push(SaveData());
                      Products.Insert(0, product);
                      selectedProduct = product;
                  }));
            }
        }

        // команда удаления объекта
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      histForBack.Form.Push(SaveData());
                      Product product = obj as Product;
                      if (product != null)
                      {
                          Products.Remove(product);
                      }
                  },
                 (obj) => Products.Count > 0));
            }
        }

        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;

            // данные по умлолчанию
            Products = new ObservableCollection<Product>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
