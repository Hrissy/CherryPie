using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Reflection;

public sealed class PageFactory
{
    private PageFactory();

    public static T InitElements<T>(IWebDriver driver);

    public static T InitElements<T>(IElementLocator locator);

    public static void InitElements(ISearchContext driver, object page);

    public static void InitElements(ISearchContext driver, object page, IPageObjectMemberDecorator decorator);

    public static void InitElements(object page, IElementLocator locator);

    public static void InitElements(object page, IElementLocator locator, IPageObjectMemberDecorator decorator);
}
