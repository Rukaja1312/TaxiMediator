using TaxiMediator;

Dispatcher dispatcher = new Dispatcher();
dispatcher.Add();

dispatcher.SendMessage(new Customer().Call("Avrena"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Zlaten Rog"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Diana"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Karngon"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Benkovsi"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Iztok"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Kurtkaq"));
dispatcher.TaxiIsBusy();
dispatcher.SendMessage(new Customer().Call("Borovec"));
dispatcher.TaxiIsBusy();