using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace RDK.Classes
{
    public class CheckFields
    {
        /// <summary>
         /// Проверка полей для регистрации пользователя
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Поля заполнены (true), поля не заполнены (false)</returns>
        public static bool CheckUser(string surname, string name, string login, string password)
        {
            if (!string.IsNullOrWhiteSpace(surname))
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (!string.IsNullOrWhiteSpace(login))
                    {
                        if (!string.IsNullOrWhiteSpace(password))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Заполните поле Пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле Логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле Имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Заполните поле Фамилия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        /// <summary>
        /// Проверка полей при авторизации
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public static bool CheckAuthorization(string login, string password)
        {
            if (!string.IsNullOrWhiteSpace(login))
            {
                if (!string.IsNullOrWhiteSpace(password))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Заполните поле Пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Заполните поле Логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        /// <summary>
        /// Проверка наличия логина в базе данных
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>Поля заполнены (true), поля не заполнены (false)</returns>
        public static bool CheckLogin(string login, LoginedTable loginedTable)
        {
            LoginedTable logined;
            //если мы задали пустой объект то просто ищем такой логин в базе, а если задали не пустой объект то ищем совпадаения с другими пользователями
            if (loginedTable == null)
            {
                logined = Classes.DataBaseClass.connect.LoginedTable.FirstOrDefault(x => x.Login == login);//по логину ищем объект в базе данных
            }
            else
            {
                logined = Classes.DataBaseClass.connect.LoginedTable.FirstOrDefault(x => x.Login == login && x.ID != loginedTable.ID);//по логину ищем объект в базе данных
            }
            if (logined == null)//если объект нулевой то возвращаем true
            {
                return true;
            }
            else
            {
                MessageBox.Show("Такой логин уже существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }

        public static bool CheckEmployee(string surname, string name, string pname, DateTime dateB, string snils, string inn,DateTime dateT, string number) 
        {
            if (!string.IsNullOrWhiteSpace(surname))
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    
                        if (dateB != null)
                        {
                            if (!string.IsNullOrWhiteSpace(snils))
                            {
                                if(!string.IsNullOrWhiteSpace(inn))
                                {
                                    if(dateT!=null)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Заполните поле Дату трудоустройства!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Заполните поле ИНН!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Заполните поле СНИЛС!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заполните поле Дату рождения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            return false;
                        }
                   
                }
                else
                {
                    MessageBox.Show("Заполните поле Имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Заполните поле Фамилия!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }

}

