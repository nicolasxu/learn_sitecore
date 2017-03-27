public string NewName => "Nunal Chowdhury"; // new way

public string OldName { // old way
  get {
    return "Knual Chowdhury";
  }
}

////////////////////////////////////

public int NewSum (int a, int b) => a + b; // new way

public int OldSum (int a, int b) { // old way
  return a + b;
}

////////////////////

public Point GetNewPoint (int p1, int p2) => new Point(p1, p2); // new way

public Point getOldPoint (int p1, int p2) { // old way
  return new Point(p1, p2);
}