using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace BiotusSeleniumTests
{
    public class UnitTest1 : BaseTest1
    {
        IWebDriver chrome;

        [Fact]
        public void SearchProductPageTest()
        {
            chrome = StartDriverWithURL("https://www.biotus.ua/");
            IWebElement searchProductElement = chrome.FindElement(By.Name("q"));
            searchProductElement.SendKeys("vitamine D");
            searchProductElement.SendKeys(Keys.Enter);
            IWebElement searchProductPageElement = chrome.FindElement(By.ClassName("product-item-link"));
            searchProductPageElement.Click();
            string actual = chrome.Url;
            Assert.Equal("https://biotus.ua/ua/vitamin-d3-vitamin-d-3-now-foods-vysokojeffektivnyj-50-mkg-2000-me-120-kapsul.html", actual);
        }
        [Fact]
        public void AddToBucketItemTest()
        {
            chrome = StartDriverWithURL("https://www.biotus.ua/");
            IWebElement searchProductElement = chrome.FindElement(By.Name("q"));
            searchProductElement.SendKeys("vitamine C");
            searchProductElement.SendKeys(Keys.Enter);
            IWebElement searchProductPageElement = chrome.FindElement(By.ClassName("product-item-link"));
            searchProductPageElement.Click();
            IWebElement addToBucketItemElement = chrome.FindElement(By.Id("product-addtocart-button"));
            addToBucketItemElement.Click();
            string actual = chrome.Url;
            Assert.Equal("https://biotus.ua/ua/vitamin-s-vitamin-c-biotus-500-mg-60-kapsul.html", actual);
        }
        [Fact]
        public void OrderTheTripTest()
        {
            chrome = StartDriverWithURL("http://www.berryland.com.ua/");
            IWebElement tripsElement = chrome.FindElement(By.CssSelector("a[href='/detskie-ekskursii-novoe-predstavlenie-ob-ekskursiyakh.html']"));
            tripsElement.Click();
            IWebElement tripsButtonElement = chrome.FindElement(By.ClassName("button7"));
            tripsButtonElement.Click();
            IWebElement fullNameElement = chrome.FindElement(By.Id("FullName"));
            fullNameElement.SendKeys("Test Testivna Testenko");
            IWebElement phoneNumberElement = chrome.FindElement(By.Id("Phone"));
            phoneNumberElement.SendKeys("0931111111");
            IWebElement emailElement = chrome.FindElement(By.Id("Email"));
            emailElement.SendKeys("testfortests@ua.fm");
            IWebElement orderTripButtonElement = chrome.FindElement(By.Name("form[Submit]"));
            orderTripButtonElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://www.berryland.com.ua/component/rsform/form/4-rsform-pro-example-copy.html", actual);

        }
        [Fact]
        public void FeedBackFormTest()
        {
            chrome = StartDriverWithURL("http://www.berryland.com.ua/");
            IWebElement contactsElement = chrome.FindElement(By.CssSelector("a[href='/o-nas-kontakty.html']"));
            contactsElement.Click();
            IWebElement fullNameElement = chrome.FindElement(By.Id("jform_contact_name"));
            fullNameElement.SendKeys("Test Testivna Testenko");
            IWebElement emailNameElement = chrome.FindElement(By.Name("jform[contact_email]"));
            emailNameElement.SendKeys("testfortests@ua.fm");
            IWebElement topiclNameElement = chrome.FindElement(By.Id("jform_contact_emailmsg"));
            topiclNameElement.SendKeys("It's a test");
            IWebElement textAriaElement = chrome.FindElement(By.Id("jform_contact_message"));
            textAriaElement.SendKeys("It's a test");
            IWebElement submitFeedBackElement = chrome.FindElement(By.XPath("//button[@type='submit']"));
            submitFeedBackElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://www.berryland.com.ua/o-nas-kontakty.html", actual);
        }
        [Fact]
        public void RegistrationFormTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement registrationElement = chrome.FindElement(By.LinkText("Регистрация"));
            registrationElement.Click();
            IWebElement nameElement = chrome.FindElement(By.Name("customer_firstname"));
            nameElement.SendKeys("Testa");
            IWebElement name2Element = chrome.FindElement(By.Id("customer_lastname"));
            name2Element.SendKeys("Testenko");
            IWebElement phoneElement = chrome.FindElement(By.Id("phone_mobile"));
            phoneElement.SendKeys("+380931111111");
            IWebElement emailElement = chrome.FindElement(By.Id("email"));
            emailElement.SendKeys("test7@ua.fm");
            IWebElement passwordElement = chrome.FindElement(By.Id("passwd"));
            passwordElement.SendKeys("Test4Tests!");
            IWebElement submittButtonElement = chrome.FindElement(By.XPath("//input[@id='submitAccount']"));
            submittButtonElement.Click();
            IWebElement accountElement = chrome.FindElement(By.LinkText("Testa Testenko"));
            accountElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://dnepr.i-mne.com/my-account.php", actual);
        }
        [Fact]
        public void AutorizationFormTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement accountElement = chrome.FindElement(By.LinkText("Testa Testenko"));
            accountElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://dnepr.i-mne.com/my-account.php", actual);
        }
        [Fact]
        public void AddNewAdressInAccountTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement accountElement = chrome.FindElement(By.LinkText("Testa Testenko"));
            accountElement.Click();
            IWebElement myAdressElement = chrome.FindElement(By.LinkText("Мои адреса"));
            myAdressElement.Click();
            IWebElement addNewAdressElement = chrome.FindElement(By.LinkText("Добавить адрес"));
            addNewAdressElement.Click();
            IWebElement phoneElement = chrome.FindElement(By.Id("phone_mobile"));
            phoneElement.SendKeys("+380931111116");
            IWebElement submittAdressElement = chrome.FindElement(By.Id("submitAddress"));
            submittAdressElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://dnepr.i-mne.com/addresses.php", actual);
        }
        [Fact]
        public void MakeAnOrderTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement searchProductElement = chrome.FindElement(By.Id("search_query"));
            searchProductElement.SendKeys("масло");
            searchProductElement.SendKeys(Keys.Enter);
            IWebElement putToBucket1Element = chrome.FindElement(By.XPath("//span[@id='product_buttons_826']"));
            putToBucket1Element.Click();
            IWebElement putToBucket2Element = chrome.FindElement(By.XPath("//span[@id='product_buttons_808']"));
            putToBucket2Element.Click();
            IWebElement accountElement = chrome.FindElement(By.LinkText("Оформить заказ"));
            accountElement.Click();
            IWebElement submittOrderElement = chrome.FindElement(By.Name("processOPC"));
            submittOrderElement.Click();
            IWebElement submitOrderTextElement = chrome.FindElement(By.XPath("//div/span[2]"));
            string actual = submitOrderTextElement.Text;
            Assert.Equal("Заказ подтвержден", actual);
        }
        [Fact]
        public void AddToListOfProductsTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement newItemsElement = chrome.FindElement(By.ClassName("categories-item__img"));
            newItemsElement.Click();
            IWebElement newItemOpenElement = chrome.FindElement(By.CssSelector("a[href='http://dnepr.i-mne.com/product.php?id_product=952']"));
            newItemOpenElement.Click();
            IWebElement addToListElement = chrome.FindElement(By.LinkText("Добавить в список"));
            addToListElement.Click();
            IWebElement newListElement = chrome.FindElement(By.Id("add-list"));
            newListElement.Click();
            IWebElement nameNewListElement = chrome.FindElement(By.Name("list-name"));
            nameNewListElement.SendKeys("Favorits");
            nameNewListElement.SendKeys(Keys.Enter);
            IWebElement submittNewListElement = chrome.FindElement(By.ClassName("add-product-div"));
            submittNewListElement.Click();
            IWebElement accountElement = chrome.FindElement(By.XPath("//a[contains(text(),'Testa Testenko')]"));
            accountElement.Click();
            IWebElement myAdressElement = chrome.FindElement(By.LinkText("Мои списки товаров"));
            myAdressElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://dnepr.i-mne.com/lists.php", actual);
        }
        [Fact]
        public void TransitionByExternalRefTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement linkTextElement = chrome.FindElement(By.LinkText("Ассортиментная политика сети"));
            linkTextElement.Click();
            IWebElement blacklinkTextElement = chrome.FindElement(By.XPath("//a[contains(text(),'Чёрный список товаров И-МНЕ')]"));
            blacklinkTextElement.Click();
            string actual = chrome.Url;
            Assert.Equal("https://moskva.i-mne.com/blogs/articles/chyornyy-spisok-tovarov-i-mne", actual);

        }
        [Fact]
        public void ExitFromAccountTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement categoryElement = chrome.FindElement(By.XPath("//div[2]/ul/li[4]/a"));
            categoryElement.Click();
            IWebElement addToBucketElement = chrome.FindElement(By.XPath("//span/a[2]"));
            addToBucketElement.Click();
            IWebElement clotheTheBucketElement = chrome.FindElement(By.XPath("//div[2]/button"));
            clotheTheBucketElement.Click();
            IWebElement profileElement = chrome.FindElement(By.XPath("//div[3]/a[2]"));
            profileElement.Click();
            IWebElement profileTheBucketElement = chrome.FindElement(By.XPath("//div[3]/a[2]"));
            profileTheBucketElement.Click();
            IWebElement exiteProfiletElement = chrome.FindElement(By.XPath("//main/div/div/ul/li[5]/a"));
            exiteProfiletElement.Click();
            string actual = chrome.Url;
            Assert.Equal("http://dnepr.i-mne.com/index.php", actual);
        }
        [Fact]
        public void WatchOrderStoryTest()
        {
            chrome = StartDriverWithURL("http://dnepr.i-mne.com/");
            IWebElement enterButtonElement = chrome.FindElement(By.XPath("//a[contains(text(),'Вход')]"));
            enterButtonElement.Click();
            IWebElement emailFieldElement = chrome.FindElement(By.Id("email_ajax"));
            emailFieldElement.SendKeys("test4@ua.fm");
            IWebElement passwordFieldElement = chrome.FindElement(By.Id("passwd_ajax"));
            passwordFieldElement.SendKeys("Test4Tests!");
            IWebElement submittElement = chrome.FindElement(By.Id("SubmitLogin_ajax"));
            submittElement.Click();
            IWebElement searchProductElement = chrome.FindElement(By.Id("search_query"));
            searchProductElement.SendKeys("орехи");
            searchProductElement.SendKeys(Keys.Enter);
            IWebElement putToBucket1Element = chrome.FindElement(By.XPath("//span[@id='product_buttons_238']"));
            putToBucket1Element.Click();
            IWebElement accountElement = chrome.FindElement(By.LinkText("Оформить заказ"));
            accountElement.Click();
            IWebElement submittOrderElement = chrome.FindElement(By.Name("processOPC"));
            submittOrderElement.Click();
            IWebElement submittOrderElement1 = chrome.FindElement(By.XPath("//small[2]/a[2]"));
            submittOrderElement1.Click();
            IWebElement watchOrderElement = chrome.FindElement(By.XPath("//td/a/span"));
            watchOrderElement.Click();
            IWebElement watchOrderElement1 = chrome.FindElement(By.XPath("//td/div/p"));
            string actual = watchOrderElement1.Text;
            Assert.Equal("Заказ № 007961 от 30-12-2021", actual);
        }
    }
}