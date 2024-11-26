class ArrayItems {
    int key;
    String value;
    ItemState status;

    // Contructor
    ArrayItems(int key, String value, ItemState status) {
        this.key = key;
        this.value = value;
        this.status = status;

    }

}

enum ItemState {
    EMPTY,
    OCCUPIED,
    DELETED,

}

class DictUsingHashingLinearProbing {
    ArrayItems[] arr;
    int size;
    int currentNumbOfItems;

    // Constructor
    DictUsingHashingLinearProbing() {
        size = 0;
        arr = new ArrayItems[23];
        for (ArrayItems items : arr) {
            items.status = ItemState.EMPTY;
        }
    }

    int getHash(int key) {
        return key % 23;

    }

    // Showing case for handling strings with hashing
    // int getHash(String key) {
    // //Horner's rules
    // int accumulator = 1;
    // for(int i; i<key.length();){

    // }
    // return key % 23;

    // }

    int linearProbing(int HashedKeyOrIndex, int key) {
        int HashID = HashedKeyOrIndex;
        int availableIndex = -1;
        boolean found = false;

        while (!found && arr[HashID].status != ItemState.EMPTY) {
            if (arr[HashID].status == ItemState.OCCUPIED) {
                if (arr[HashID].key == key)
                    found = true;

                else
                    HashID = (HashID + 1) % 23;

            } else {
                availableIndex = HashID;
                HashID = (HashID + 1) % 23;
            }
        }
        if (found || availableIndex == -1)
            return HashID;
        else
            return availableIndex;
    }

    void add(int key, String valeu) {
        int HashedKeyOrIndex = getHash(key);
        int indexFromProbing = linearProbing(HashedKeyOrIndex, key);
        arr[indexFromProbing] = new ArrayItems(HashedKeyOrIndex, valeu, ItemState.OCCUPIED);
        currentNumbOfItems++;
    }

    String get(int key) throws Exception {
        int hashedKey = getHash(key);
        int indexFromProbing = linearProbing(hashedKey, key);
        if (arr[indexFromProbing].key == key) {

        }
        return arr[linearProbing(hashedKey, key)].value;
    }

    void remove(int key) {
        arr[linearProbing(getHash(key), key)].status = ItemState.DELETED;
    }

    boolean contains(int key) throws Exception {
        try {
            String value = this.get(key);
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    int size() {
        return size;
    }

public static void main(String[] args) {
    DictUsingHashingLinearProbing Dict1 = new DictUsingHashingLinearProbing();

    try {
    Dict1.add(29, "29");
    Dict1.add(32,"32");
    Dict1.add(58,"58");
    Dict1.add(21,"21");

    System.err.println(Dict1.get(29));

    Dict1.remove(32);
    Dict1.add()



        
    } catch (Exception e) {
        
        
        
        
        // TODO: handle exception
    }
    
    

}

}