//
//  ViewController.swift
//  8Ball
//
//  Created by english on 2020-06-03.
//  Copyright © 2020 english. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    let ballArry = ["ball1","ball2","ball3","ball4","ball5"]
       var randomBallIndex :Int = 0

    @IBOutlet weak var Ans: UIImageView!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
    }

    @IBAction func Ask(_ sender: Any) {
        
    randomBallIndex = Int(arc4random_uniform(5))
    Ans.image = UIImage(named: ballArry[randomBallIndex])
    
    
    
    
    
    }
    
}

