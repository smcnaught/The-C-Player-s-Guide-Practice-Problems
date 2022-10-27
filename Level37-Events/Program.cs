Tree tree = new Tree();
Announcer announcer = new Announcer(tree);
Harvester harvester = new Harvester(tree);
while (true) {
  tree.TryGrow();
}