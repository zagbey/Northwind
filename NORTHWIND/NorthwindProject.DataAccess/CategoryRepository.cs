using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities;



namespace NorthwindProject.DataAccess
{
    public class CategoryRepository
    {
        //category List Form da oluşan kategoriyi bir category<>list oluşturup içine atıyoruz ordan geliyo

        //veritabanındaki tüm kayıtları getir
        public List<Category> Getall()
        {
            const string sqlText = "select * from Categories";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var categoryList = conn.Query<Category>(sqlText).ToList();
                    return categoryList;
                }

            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return new List<Category> { }; //boş bir listeyi temsil etmek için yaptık 
                                               //null değer değil de bunun yerine boş bir liste çeviriyoruz 
            }

        }

        //Find ;GetByID : bildirdiğim ıd değerine sahip olan tek kaydı getir 
        public Category? Find(int categoryId)
        {
            const string sqlText = "select * from Categories where CategoryID=@categoryId";
            try
            {
                using (var sqlConn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var category = sqlConn.QuerySingleOrDefault<Category>(sqlText, new { categoryId });//sorgu sonucunu kategoriye maple <Category>
                    //QuerySingleOrDefaolut veri tabanından tek bir satır halinde verleri çekmeye yarıyor
                    return category;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());

                return null; //tekil nesneler için yukarıdakinin aksine null dur koleksiyonlarda boş bir listedir 
            }
        }

        //Bildirdiğim nesneyi veritabanına satır oalrak ekle
        public bool Add(Category category)
        {
            const string sqlQuery = @"insert into Categories (CategoryName,Description)
                                      values
                                    (@CategoryName,
                                     @Description)
                                            ";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    conn.Execute(sqlQuery, category);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return false;
            }
        }
        //bildirdiğim nesneyi satırı veritabanında güncelle 

        public bool Update(Category category)
        {

            const string updateCategorySql = @"
update Categories 
set 
CategoryName=@CategoryName,
Description=@Description
where CategoryID=@CategoryID

";
            try
            {
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(updateCategorySql, category);
                    return affectedRows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return false;
            }

        }

        //remove,delete : bildirdiğim nesneyi satırı veritabanından sil 
        public bool Remove(Category category)
        {
            try
            {
                const string selectedProductSql = "Delete from Categories where CategoryID=@CategoryID";
                using (var conn = new SqlConnection(DbSettings.ConnectionString))
                {
                    var affectedRows = conn.Execute(selectedProductSql, category);
                    return affectedRows > 0;
                }

            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());

                return false;
            }
        }
        public bool Remove(int categoryId)
        {
            var category = new Category()
            {
                CategoryID = categoryId
            };

            return Remove(category);
        }
    }
}
