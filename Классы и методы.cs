namespace MaratProject
{
    class Programm
    {
        static void Main(string[] args)
        {

        }
    }
    public class Client
    {
        public int ID;
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Mail;
        public string Country;
        public string City;
        public int Index;
        public string address;
        public string PhoneNumber;
        private int Paid = 0;

        public void Booking()
        {
            if (Paid == 2000)
            {
                Console.WriteLine("Клиент забронировал заказ");
            }
            if (Paid > 2000)
            {
                Console.WriteLine($"Было внесено {Paid}. Клиент оформил заказ, можно начинать изготовление");
            }
        }

        public void RequestPhoto()
        {
            Console.WriteLine("Пришлите пожалуйста фото нард");
        }

        public void RequestDocuments()
        {
            Console.WriteLine("В содержимое посылки положите закрывающие документы");
        }

        public void RequestContract()
        {
            Console.WriteLine("Давайте заключим с вами договор купли-продажи");
        }
    }

    public class Products
    {
        public int ID;
        public string Description;
        public int Price = 0;
        public string Title;
        public int Availability = 0;
        private string OrderStatus = "Нарды готовы к оптравке";

        public void Sending()
        {
            if (OrderStatus == "Нарды готовы к оптравке")
            {
                Console.WriteLine("Нарды отправлены");
            }
        }

        public void PriceProducts()
        {
            if (Price > 0)
            {
                Console.WriteLine($"Стоимость товара равна {Price} рублей");
            }
        }

        public void RemoveProduct()
        {
            if (Availability == 0)
            {
                Console.WriteLine("Товар убран с продажи");
            }
        }

        public void EditAviability()
        {
            Console.WriteLine($"Были сделаны еще одни нарды. Их количество стало {Availability}");
        }

        public void PurProdactForSale()
        {
            Console.WriteLine("Товар сделан и выставлен на продажу");
        }
    }

    public class Managers
    {
        public int ID;
        public string Surname;
        public string Name;
        public string Patronymic;
        public int Earnings;
        public int Fine;

        public string GetFullName()
        {
            return $"{Surname} {Name} {Patronymic}";
        }

        public void Salary()
        {
            Console.WriteLine($"Осуществлен перевод в размере {Earnings * 0.05}");
        }

        public void FineManager()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} сделан выговор");
        }

        public void AcceptOnTheJob()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} принят(а) на работу в качестве менеджера");
        }

        public void Promotion()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} повышен(а) до руководителя отдела продаж");
        }

        public void Dismiss()
        {
            if (Fine == 3)
            {
                Console.WriteLine($"{Surname} {Name} {Patronymic} уволен(а) с работы");
            }
        }
    }

    public class Orders
    {
        public int ID;
        public int TotalNumber;
        public int Amount;
        public int Discount;
        public DateTime DateAndTime;
        public int ClientID;
        public Client Client;
        public string OrderStatus = "Заказ оформляется";

        public void CreateOrder()
        {
            if (ID > 0)
            {
                Console.WriteLine($"Создан новый заказ с номером {ID}");
            }
        }

        public void AddProducts()
        {
            if (TotalNumber > 0)
            {
                Console.WriteLine($"Были добавлены товары в корзину, их общее число равнаяется {TotalNumber}");
            }
        }

        public void ApplyDiscount()
        {
            if (Amount > 50000)
            {
                Console.WriteLine($"К заказу была применена скидка в размере {Discount} процентов");
            }
        }

        public void CancelOrder()
        {
            if (OrderStatus == "Заказ отменен")
            {
                Console.WriteLine("Клиент отменил заказ");
            }
        }

        public void ChangeStatus()
        {
            Console.WriteLine($"Статус заказа был изменен на {OrderStatus}");
        }

        public void FillOutCard()
        {
            Console.WriteLine("Карточка заказа была успешно заполнена");
        }
    }

    public class OrdersList
    {
        public int OrderID;
        public Orders Orders;
        public int ManagersID;
        public Managers Managers;
        public int ProductsID;
        public Products Products;
        public int Quantity;
    }

    public class Sales
    {
        public int SaleID;
        public string Title;
        public int ProductsID;
        public Products Products;
        public int PerCentDiscount;
        public DateOnly StartSale;
        public DateOnly EndSale;
        public string Status;

        public void CreateSale()
        {
            if (SaleID > 0)
            {
                Console.WriteLine("Акция была успешно сформирована");
            }
        }

        public void SentSale()
        {
            if (Status == "Активна")
            {
                Console.WriteLine("Акция была упешно разослана клиентам");
            }
        }

        public void ChangeStatus()
        {
            Console.WriteLine($"Статус акции был изменен на {Status}");
        }

        public void ChangePerCentDiscount()
        {
            Console.WriteLine($"Процент скидки был изменен на {PerCentDiscount}");
        }

        public void ChangeTitle()
        {
            Console.WriteLine($"Название акции было изменено на {Title}");
        }
    }

    public class Complaints
    {
        public int CompalintID;
        public int ClientID;
        public Client Client;
        public string Content;
        public string Status;

        public void ChangeComplaintsStatus()
        {
            Console.WriteLine($"Статус жалобы был изменен на {Status}");
        }

        public void SentAnswer()
        {
            Console.WriteLine("Ответ по жалобе был успешно отправлен");
        }

        public void DeleteComplaints()
        {
            Console.WriteLine("Жалоба была успешно удалена");
        }
    }

    public class Feedback
    {
        public int FeedbackID;
        public int ClientID;
        public Client Client;
        public string Content;

        public void SentAnswerOnFeedback()
        {
            Console.WriteLine("Ответ на отзыв был успешно отправлен");
        }

        public void DeleteCFeedback()
        {
            Console.WriteLine("Отзыв был успешно удален");
        }
    }
}