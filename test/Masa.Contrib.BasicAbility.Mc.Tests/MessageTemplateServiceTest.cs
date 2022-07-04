// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.Contrib.BasicAbility.Mc.Tests;

[TestClass]
public class MessageTemplateServiceTest
{
    [TestMethod]
    public async Task TestGetAsync()
    {
        var data = new MessageTemplateModel();
        Guid id = Guid.NewGuid();
        var requestUri = $"api/message-template/{id}";
        var callerProvider = new Mock<ICallerProvider>();
        callerProvider.Setup(provider => provider.GetAsync<MessageTemplateModel>(requestUri, default)).ReturnsAsync(data).Verifiable();
        var messageTemplateService = new Mock<MessageTemplateService>(callerProvider.Object);
        var result = await messageTemplateService.Object.GetAsync(id);
        callerProvider.Verify(provider => provider.GetAsync<MessageTemplateModel>(requestUri, default), Times.Once);
        Assert.IsTrue(result is not null);
    }

    [TestMethod]
    public async Task TestGetListAsync()
    {
        var options = new GetMessageTemplateModel();
        var data = new PaginatedListModel<MessageTemplateModel>();
        var requestUri = $"api/message-template";
        var callerProvider = new Mock<ICallerProvider>();
        callerProvider.Setup(provider => provider.GetAsync<GetMessageTemplateModel, PaginatedListModel<MessageTemplateModel>>(requestUri, options, default)).ReturnsAsync(data).Verifiable();
        var messageTemplateService = new Mock<MessageTemplateService>(callerProvider.Object);
        var result = await messageTemplateService.Object.GetListAsync(options);
        callerProvider.Verify(provider => provider.GetAsync<GetMessageTemplateModel, PaginatedListModel<MessageTemplateModel>>(requestUri, options, default), Times.Once);
        Assert.IsTrue(result is not null);
    }
}
