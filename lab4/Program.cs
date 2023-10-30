// observer
Stakeholder owner = new Stakeholder();
VendingMachine machine = new VendingMachine();

machine.addSubscriber(owner);

// state
// machine.operate();
// machine.operate();
// machine.operate();
// machine.operate();
// machine.showState();

// iterator
VendingMachine[] machinesCollection = {
    new VendingMachine("Iasi"),
    new VendingMachine("Iasi"),
    new VendingMachine("Chisinau"),
    new VendingMachine("Iasi"),
    new VendingMachine("Iasi"),
    new VendingMachine("Bucuresti")
};

VendingMachineIterator machines = new VendingMachineIterator(machinesCollection);

machines.iterateAllAndPrint("Iasi");
Console.WriteLine();
machines.iterateAllAndPrint("Chisinau");
Console.WriteLine();
// or iterate this way
while(machines.hasMore()) {
    VendingMachine? m = machines.getNext("Iasi");

    if(m == null)
        break;

    Console.WriteLine(m.location);
}